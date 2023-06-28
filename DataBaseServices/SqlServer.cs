using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROGRAMACION_3_TP_FINAL.Entities;

namespace PROGRAMACION_3_TP_FINAL.DataBaseServices
{
    public class SqlServer : dbServicesInterface
    {
        private string connectionStr = @"Data Source=DESKTOP-GLJMCO1\SQLEXPRESS;Initial Catalog=projectDB;Integrated Security=True";
        public SqlServer()
        {
        }

        public string deleteRow(string tableName, string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    string deleteQuery = $"DELETE FROM {tableName} WHERE {condition}";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string insertRow(object obj, string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    var properties = obj.GetType().GetProperties();

                    string insertQuery = $"INSERT INTO {tableName} (";
                    string valuesQuery = "VALUES (";
                    bool isFirst = true;

                    foreach (var property in properties)
                    {
                        if (property.Name == "id") continue;
                        if (!isFirst)
                        {
                            insertQuery += ", ";
                            valuesQuery += ", ";
                        }

                        insertQuery += property.Name;
                        valuesQuery += "@" + property.Name;

                        isFirst = false;
                    }

                    insertQuery += ") " + valuesQuery + ")";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        foreach (var property in properties)
                        {
                            command.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj));
                        }

                        command.ExecuteNonQuery();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<object> searchRow(Type objectType, string tableName, string condition)
        {
            List<object> resultList = new List<object>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    string selectQuery = $"SELECT * FROM {tableName} WHERE {condition}";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                object obj = Activator.CreateInstance(objectType);

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string columnName = reader.GetName(i);
                                    var property = objectType.GetProperty(columnName);

                                    if (property != null)
                                    {
                                        property.SetValue(obj, reader.GetValue(i));
                                    }
                                }

                                resultList.Add(obj);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar filas: " + ex.Message);
            }

            return resultList;
        }
        public string updateRow(object obj, string tableName, string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    var properties = obj.GetType().GetProperties();

                    string updateQuery = $"UPDATE {tableName} SET ";
                    bool isFirst = true;

                    foreach (var property in properties)
                    {
                        if (property.Name == "id") continue;
                        if (!isFirst)
                        {
                            updateQuery += ", ";
                        }

                        updateQuery += $"{property.Name} = @{property.Name}";

                        isFirst = false;
                    }

                    updateQuery += $" WHERE {condition}";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        foreach (var property in properties)
                        {
                            command.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj));
                        }

                        command.ExecuteNonQuery();
                    }
                }

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}