using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace PennslyvaniaNationalParks.Models
{

    public class SeedData
    {
        public string ConnectionString { get; set; }

        public SeedData(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        
        void SaveAllParks(Parks[] parks)
        {

            using (MySqlConnection conn = GetConnection())
            {

                MySqlCommand cmd = new MySqlCommand("INSERT IGNORE INTO park_table (ID, Name, Description, Url, PhoneNumber, Email) " +
                                                     "values (@Id, @Name, @Description, @Url, @PhoneNumber, @Email)", conn);
                conn.Open();

                for (int i = 0; i < parks.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@Id", parks[i].ID);
                    cmd.Parameters.AddWithValue("@Name", parks[i].Name);
                    cmd.Parameters.AddWithValue("@Description", parks[i].Description);
                    cmd.Parameters.AddWithValue("@Url", parks[i].Url);
                    cmd.Parameters.AddWithValue("@PhoneNumber", parks[i].PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", parks[i].Email);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                conn.Close();
            }
        }

        public async void RetrieveParkData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://developer.nps.gov/api/v1/parks?stateCode=PA&api_key=cnbfovFGwX7TmXj2KkSkeOGYhHgkOz3IiRsg5kak");

            dynamic objectData = response.Content.ReadAsAsync<dynamic>().Result;
            dynamic data = objectData["data"];
            Parks[] parks = new Parks[data.Count];

            for (int i = 0; i < parks.Length; i++)
            {
                parks[i] = new Parks();
                parks[i].Name = data[i]["fullName"];
                parks[i].Description = data[i]["description"];
                parks[i].ID = data[i]["id"];
                parks[i].Url = data[i]["url"];
                try
                {
                    parks[i].PhoneNumber = data[i]["contacts"]["phoneNumbers"][0]["phoneNumber"];
                }
                catch
                {
                    parks[i].PhoneNumber = null;
                }
                try
                {
                    parks[i].Email = data[i]["contacts"]["emailAddresses"][0]["emailAddress"];
                }
                catch
                {
                    parks[i].Email = null;
                }
            }
            SaveAllParks(parks);
        }
    }
}


