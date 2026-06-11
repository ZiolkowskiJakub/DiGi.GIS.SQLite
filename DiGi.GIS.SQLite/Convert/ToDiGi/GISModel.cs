using DiGi.GIS.Classes;
using DiGi.SQLite.Classes;
using System.Collections.Generic;

namespace DiGi.GIS.SQLite
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a SQLite file at the specified path into a <see cref="GISModel"/> object.
        /// </summary>
        /// <param name="path">The file system path to the SQLite database file.</param>
        /// <returns>A <see cref="GISModel"/> instance if the file exists and contains valid data; otherwise, null.</returns>
        public static GISModel ToDiGi(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            GISModel result = null;

            using (SQLiteWrapper sQLiteWrapper = new SQLiteWrapper())
            {
                sQLiteWrapper.ConnectionString = DiGi.SQLite.Query.ConnectionString(path);
                sQLiteWrapper.Read();

                List<GISModel> gISModels = sQLiteWrapper.GetSerializableObjects<GISModel>();
                if (gISModels == null || gISModels.Count == 0)
                {
                    return result;
                }

                result = gISModels[0];
            }

            return result;
        }
    }
}