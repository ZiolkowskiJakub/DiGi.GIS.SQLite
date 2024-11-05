using DiGi.Core.Interfaces;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;
using DiGi.SQLite.Classes;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;

namespace DiGi.GIS.SQLite
{
    public static partial class Convert
    {
        public static bool ToSQLite_OLD(this GISModel gISModel, string path)
        {
            if (gISModel == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            List<ISerializableObject> serializableObjects = new List<ISerializableObject>();

            ISource source = gISModel.GetObject<ISource>();
            if (source != null)
            {
                serializableObjects.Add(source);
            }

            List<IGISUniqueObject> gISUniqueObjects = gISModel.GetObjects<IGISUniqueObject>();
            if (gISUniqueObjects != null)
            {
                serializableObjects.AddRange(gISUniqueObjects);
            }

            List<IGISRelation> gISRelations = gISModel.GetRelations<IGISRelation>();
            if (gISRelations != null)
            {
                serializableObjects.AddRange(gISRelations);
            }

            return ToSQLite(serializableObjects, path);
        }

        public static bool ToSQLite<T>(this IEnumerable<T> serializableObjects, string path) where T : ISerializableObject
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            bool result = false;

            using (SqliteConnection sqliteConnection = new SqliteConnection($"Data Source={path}"))
            {
                try
                {
                    sqliteConnection.Open();

                    result = ToSQLite(serializableObjects, sqliteConnection);
                }
                catch (Exception exception)
                {
                    throw exception;
                }
                finally
                {
                    sqliteConnection.Close();
                }
            }

            return result;
        }

        public static bool ToSQLite<T>(this IEnumerable<T> serializableObjects, SqliteConnection sqliteConnection) where T : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return false;
            }

            Dictionary<string, List<T>> dictionary = new Dictionary<string, List<T>>();
            foreach (T serializableObject in serializableObjects)
            {
                string fullTypeName = Core.Query.FullTypeName(serializableObject?.GetType());
                if (string.IsNullOrWhiteSpace(fullTypeName))
                {
                    continue;
                }

                if (!dictionary.TryGetValue(fullTypeName, out List<T> serializableObjects_Temp) || serializableObjects_Temp == null)
                {
                    serializableObjects_Temp = new List<T>();
                    dictionary[fullTypeName] = serializableObjects_Temp;
                }

                serializableObjects_Temp.Add(serializableObject);
            }

            using (SqliteCommand sqliteCommand = new SqliteCommand() { Connection = sqliteConnection })
            {
                sqliteCommand.CommandText = @"CREATE TABLE IF NOT EXISTS Types (Id INTEGER PRIMARY KEY AUTOINCREMENT, FullTypeName TEXT NOT NULL UNIQUE)";
                sqliteCommand.ExecuteNonQuery();

                sqliteCommand.CommandText = "INSERT OR IGNORE INTO Types (FullTypeName) VALUES (@FullTypeName)";
                foreach (string fullTypeName in dictionary.Keys)
                {
                    sqliteCommand.Parameters.Clear();
                    sqliteCommand.Parameters.AddWithValue("@FullTypeName", fullTypeName);

                    sqliteCommand.ExecuteNonQuery();
                }

                foreach (KeyValuePair<string, List<T>> keyValuePair in dictionary)
                {
                    if (keyValuePair.Value == null || keyValuePair.Value.Count == 0)
                    {
                        continue;
                    }

                    string fullTypeName = keyValuePair.Key;

                    sqliteCommand.CommandText = "SELECT Id FROM Types WHERE FullTypeName = @FullTypeName LIMIT 1";

                    sqliteCommand.Parameters.Clear();
                    sqliteCommand.Parameters.AddWithValue("@FullTypeName", fullTypeName);

                    int typeId = System.Convert.ToInt32(sqliteCommand.ExecuteScalar());

                    string tableName = string.Format("Type_{0}", typeId);

                    sqliteCommand.CommandText = string.Format(@"CREATE TABLE IF NOT EXISTS {0} (Id INTEGER PRIMARY KEY AUTOINCREMENT, Reference TEXT NOT NULL UNIQUE, Json TEXT NOT NULL)", tableName);
                    sqliteCommand.ExecuteNonQuery();

                    sqliteCommand.CommandText = string.Format("INSERT OR REPLACE INTO {0} (Reference, Json) VALUES (@Reference, @Json)", tableName);

                    sqliteCommand.Parameters.Clear();

                    SqliteParameter sqliteParameter_Reference = new SqliteParameter("@Reference", SqliteType.Text);
                    sqliteCommand.Parameters.Add(sqliteParameter_Reference);

                    SqliteParameter sqliteParameter_Json = new SqliteParameter("@Json", SqliteType.Text);
                    sqliteCommand.Parameters.Add(sqliteParameter_Json);

                    foreach (T serializableObject in keyValuePair.Value)
                    {
                        if (serializableObject == null)
                        {
                            continue;
                        }

                        string reference = serializableObject.Reference();
                        if (reference == null)
                        {
                            continue;
                        }

                        string json = Core.Convert.ToString(serializableObject);
                        if (json == null)
                        {
                            continue;
                        }

                        sqliteParameter_Reference.Value = reference;
                        sqliteParameter_Json.Value = json;

                        sqliteCommand.ExecuteNonQuery();
                    }
                }
            }

            return true;
        }

        public static bool ToSQLite(this GISModel gISModel, string path)
        {
            if (gISModel == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            using (SQLiteWrapper sQLiteWrapper = new SQLiteWrapper())
            {
                sQLiteWrapper.ConnectionString = DiGi.SQLite.Query.ConnectionString(path);
                sQLiteWrapper.Add(gISModel);

                sQLiteWrapper.Write();
            }

            return true;
        }

    }
}

