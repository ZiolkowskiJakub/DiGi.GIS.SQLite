using DiGi.BDOT10k.UI;
using DiGi.BDOT10k.UI.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.SQLite.Classes;
using System.IO;
using System.IO.Compression;

namespace DiGi.GIS.SQLite
{
    public static partial class Modify
    {
        public static bool Extract(this SQLiteExtractOptions sQLiteExtractOptions)
        {
            if (sQLiteExtractOptions == null)
            {
                return false;
            }

            string path = sQLiteExtractOptions.SourcePath;

            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return false;
            }

            string directory = sQLiteExtractOptions.DestionationDirectory;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            {
                foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                {
                    DeflateStream deflateStream = zipArchiveEntry.Open() as DeflateStream;
                    if (deflateStream == null)
                    {
                        continue;
                    }

                    using (ZipArchive zipArchive_ZipArchieve = new ZipArchive(deflateStream))
                    {
                        foreach (ZipArchiveEntry zipArchiveEntry_Zip in zipArchive_ZipArchieve.Entries)
                        {
                            string directory_Region = Path.Combine(directory, Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name));
                            if (!Directory.Exists(directory_Region))
                            {
                                Directory.CreateDirectory(directory_Region);
                            }
                            else if (!sQLiteExtractOptions.UpdateExisting)
                            {
                                continue;
                            }

                            DeflateStream deflateStream_Zip = zipArchiveEntry_Zip.Open() as DeflateStream;
                            if (deflateStream_Zip == null)
                            {
                                continue;
                            }

                            ZipArchive zipArchive_Files = new ZipArchive(deflateStream_Zip);

                            SlownikObiektowGeometrycznych slownikObiektowGeometrycznych = new SlownikObiektowGeometrycznych();

                            foreach (ZipArchiveEntry zipArchiveEntry_File in zipArchive_Files.Entries)
                            {
                                if (zipArchiveEntry_File.Name.EndsWith(Constans.FileNamePrefix.OT_ADMS_A) || zipArchiveEntry_File.Name.EndsWith(Constans.FileNamePrefix.OT_BUBD_A))
                                {
                                    slownikObiektowGeometrycznych.Load(zipArchiveEntry_File.Open());
                                }
                            }

                            if (slownikObiektowGeometrycznych.GetObiektGeometryczny<BUBD_A>() == null || slownikObiektowGeometrycznych.GetObiektGeometryczny<ADMS_A>() == null)
                            {
                                continue;
                            }

                            DirectorySource directorySource = new DirectorySource(zipArchiveEntry_Zip.FullName);

                            GISModel gISModel = null; //GIS.Convert.ToDiGi(slownikObiektowGeometrycznych, directorySource);
                            if (gISModel == null)
                            {
                                continue;
                            }

                            string path_SQLite = Path.Combine(directory_Region, string.Format("{0}.sqlite3", Path.GetFileNameWithoutExtension(zipArchiveEntry_Zip.Name)));

                            Convert.ToSQLite(gISModel, path_SQLite);
                        };
                    }
                }
            }

            return true;
        }
    }
}

