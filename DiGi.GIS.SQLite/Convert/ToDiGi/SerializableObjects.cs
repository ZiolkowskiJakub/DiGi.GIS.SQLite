using DiGi.Core.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.SQLite
{
    public static partial class Convert
    {
        /// <summary>
        /// Deserializes a collection of objects implementing <see cref="ISerializableObject"/> from a SQLite database file at the specified path.
        /// </summary>
        /// <typeparam name="T">The type of objects to deserialize, which must implement <see cref="ISerializableObject"/>.</typeparam>
        /// <param name="path">The file system path to the SQLite database file.</param>
        /// <param name="func">An optional predicate function used to filter the deserialized objects.</param>
        /// <returns>A list of deserialized objects of type <typeparam ref="T"/>, or null if the path is invalid or the file does not exist.</returns>
        public static List<T> ToDiGi<T>(string path, Func<T, bool> func = null) where T : ISerializableObject
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            List<T> result = new List<T>();

            using (SqliteConnection sqliteConnection = new SqliteConnection($"Data Source={path}"))
            {
                try
                {
                    sqliteConnection.Open();

                    result = ToDiGi(sqliteConnection, func);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    sqliteConnection.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// Deserializes a collection of objects implementing <see cref="ISerializableObject"/> using an existing SQLite connection.
        /// </summary>
        /// <typeparam name="T">The type of objects to deserialize, which must implement <see cref="ISerializableObject"/>.</typeparam>
        /// <param name="sqliteConnection">An open <see cref="SqliteConnection"/> to the SQLite database.</param>
        /// <param name="func">An optional predicate function used to filter the deserialized objects.</param>
        /// <returns>A list of deserialized objects of type <typeparam ref="T"/>, or null if the connection is null or no compatible types are found.</returns>
        public static List<T> ToDiGi<T>(SqliteConnection sqliteConnection, Func<T, bool> func = null) where T : ISerializableObject
        {
            if (sqliteConnection == null)
            {
                return null;
            }

            using (SqliteCommand sqliteCommand = new SqliteCommand() { Connection = sqliteConnection })
            {
                sqliteCommand.CommandText = "SELECT Id, FullTypeName FROM Types";

                List<Tuple<int, Type>> tuples = new List<Tuple<int, Type>>();
                using (SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
                {
                    while (sqliteDataReader.Read())
                    {
                        string fullTypeName = sqliteDataReader.GetString(1);

                        Type type = Core.Query.Type(fullTypeName);
                        if (type == null)
                        {
                            continue;
                        }

                        if (!typeof(T).IsAssignableFrom(type))
                        {
                            continue;
                        }

                        int typeId = sqliteDataReader.GetInt32(0);

                        tuples.Add(new Tuple<int, Type>(typeId, type));
                    }
                }

                if (tuples == null || tuples.Count == 0)
                {
                    return null;
                }

                List<T> result = new List<T>();

                foreach (Tuple<int, Type> tuple in tuples)
                {
                    sqliteCommand.CommandText = string.Format(System.Globalization.CultureInfo.InvariantCulture, "SELECT Json FROM {0}", string.Format(System.Globalization.CultureInfo.InvariantCulture, "Type_{0}", tuple.Item1));
                    using (SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
                    {
                        while (sqliteDataReader.Read())
                        {
                            List<T> ts = Core.Convert.ToDiGi<T>(sqliteDataReader.GetString(0));
                            if (ts == null || ts.Count == 0)
                            {
                                continue;
                            }

                            if (func != null && !func.Invoke(ts[0]))
                            {
                                continue;
                            }

                            result.Add(ts[0]);
                        }
                    }
                }

                return result;
            }
        }
    }
}