using DiGi.GIS.Classes;
using DiGi.SQLite.Classes;
using System.Collections.Generic;

namespace DiGi.GIS.SQLite
{
    public static partial class Convert
    {
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