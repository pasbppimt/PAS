using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using PAS.Properties;

namespace PAS
{
    public static class Database
    {
        public static int Insert(string table, Dictionary<string, object> fields)
        {
            var commandText = new StringBuilder();

            commandText.Append($"INSERT INTO {table} (");
            commandText.Append(string.Join(", ", fields.Keys.Select(key => $"[{key}]").ToArray()));
            commandText.Append(") Values (");
            commandText.Append(string.Join(", ", fields.Keys.Select(key => $"@{key}").ToArray()));
            commandText.Append(")");

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                connection.Open();

                using (var command = new SQLiteCommand(commandText.ToString(), connection))
                {
                    foreach (var parameter in fields.Keys.Select(key => $"@{key}").ToArray())
                        command.Parameters.AddWithValue(parameter, fields[parameter.Replace("@", string.Empty)]);

                    command.ExecuteNonQuery();
                }

                var newCmdText = "SELECT last_insert_rowid()";
                using (var getAutoIncrementValueCommand = new SQLiteCommand(newCmdText, connection))
                {
                    return Convert.ToInt32(getAutoIncrementValueCommand.ExecuteScalar());
                }
            }
        }

        public static void Update(string table, Dictionary<string, object> fields, Dictionary<string, object> where)
        {
            var commandText = new StringBuilder();

            commandText.Append($"UPDATE {table} SET ");
            commandText.Append(string.Join(", ", fields.Keys.Select(key => $"[{key}] = @{key}").ToArray()));
            commandText.Append(" WHERE ");
            commandText.Append(string.Join(" AND ", where.Keys.Select(key => $"[{key}] = @{key}").ToArray()));

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                using (var command = new SQLiteCommand(commandText.ToString(), connection))
                {
                    foreach (var parameter in fields.Keys.Select(key => $"@{key}").ToArray())
                        command.Parameters.AddWithValue(parameter, fields[parameter.Replace("@", string.Empty)]);
                    foreach (var parameter in where.Keys.Select(key => $"@{key}").ToArray())
                        command.Parameters.AddWithValue(parameter, where[parameter.Replace("@", string.Empty)]);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(string table, Dictionary<string, object> where)
        {
            var commandText = new StringBuilder();

            commandText.Append($"DELETE FROM {table} WHERE ");
            commandText.Append(string.Join(" AND ", where.Keys.Select(key => $"[{key}] = @{key}").ToArray()));

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                using (var command = new SQLiteCommand(commandText.ToString(), connection))
                {
                    foreach (var parameter in where.Keys.Select(key => $"@{key}").ToArray())
                        command.Parameters.AddWithValue(parameter, where[parameter.Replace("@", string.Empty)]);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<object[]> Select(string table, string[] fieldNames)
        {
            var fields = new List<object[]>();

            var commandText = new StringBuilder();

            commandText.Append($"SELECT * FROM {table}");

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                using (var command = new SQLiteCommand(commandText.ToString(), connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while ((reader != null) && reader.Read())
                            fields.Add(fieldNames.Select(fieldName => reader[fieldName]).ToArray());
                    }
                }
            }

            return fields;
        }

        public static List<object[]> Select(string table, string[] fieldNames, Dictionary<string, object> where)
        {
            var fields = new List<object[]>();

            var commandText = new StringBuilder();

            commandText.Append($"SELECT * FROM {table} WHERE ");
            commandText.Append(string.Join(" AND ", where.Keys.Select(key => $"[{key}] = @{key}").ToArray()));

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                using (var command = new SQLiteCommand(commandText.ToString(), connection))
                {
                    foreach (var parameter in where.Keys.Select(key => $"@{key}").ToArray())
                        command.Parameters.AddWithValue(parameter, where[parameter.Replace("@", string.Empty)]);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while ((reader != null) && reader.Read())
                            fields.Add(fieldNames.Select(fieldName => reader[$"{fieldName}"]).ToArray());
                    }
                }
            }

            return fields;
        }

        public static List<object[]> SelectRange(string table, string[] fieldNames,
            string where, string fromDate, string toDate)
        {
            var fields = new List<object[]>();

            var commandText = new StringBuilder();

            commandText.Append($"SELECT * FROM {table} WHERE {where} ");
            commandText.Append($"BETWEEN \"{fromDate}\" AND \"{toDate}\"");

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                using (var command = new SQLiteCommand(commandText.ToString(), connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while ((reader != null) && reader.Read())
                            fields.Add(fieldNames.Select(fieldName => reader[$"{fieldName}"]).ToArray());
                    }
                }
            }

            return fields;
        }

        public static int SelectCount(string table)
        {
            var commandText = "SELECT COUNT(*) FROM " + table;

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    connection.Open();

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public static DataTable SelectAdapter(string table)
        {
            var dataTable = new DataTable();
            var commandText = "SELECT * FROM " + table;

            using (var connection = new SQLiteConnection(Resources.ConnectionString, true))
            {
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    connection.Open();

                    var sqlDataAdapter = new SQLiteDataAdapter(command);
                    sqlDataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}