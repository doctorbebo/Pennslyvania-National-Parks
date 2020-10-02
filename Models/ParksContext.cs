using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Pennslyvania_National_Parks.Models
{
    public class ParksContext
    {
        public string ConnectionString { get; set; }

        public ParksContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public List<Parks> GetAllParks()
        {
            List<Parks> list = new List<Parks>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from park_table", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Parks()
                        {
                            ID = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            Url = reader["Url"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
