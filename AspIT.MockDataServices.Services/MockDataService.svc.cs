using System.Data;
using Newtonsoft.Json;
using AspIT.MockDataServices.Entities;
using AspIT.MockDataServices.DB;
using System.ServiceModel;

namespace AspIT.MockDataServices.Services
{
    /// <summary>
    /// Represents a WCF Service that is responsible for returning stuff in JSON format/>
    /// </summary>
    public class MockDataService : IMockDataService
    {
        /// <summary>
        /// Selects all names from the DanishNames table, and then returns the names in JSON format.
        /// </summary>
        /// <returns>The names in JSON format</returns>
        public string GetAllDanishNames()
        {
            SqlExecutor sqlExecutor = new SqlExecutor();
            DataSet dataSet = sqlExecutor.Execute("SELECT FirstName,LastName FROM DanishNames");

            string jsonPeople = string.Empty;
            DataRowCollection rows = dataSet.Tables[0].Rows;
            Person[] people = new Person[rows.Count];

            for(int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                people[i] = new Person(row.Field<string>("FirstName"), row.Field<string>("LastName"));
            }

            jsonPeople = JsonConvert.SerializeObject(people);

            // Return json data
            return jsonPeople;
        }

        /// <summary>
        /// Selects the amount of names specified from the DanishNames table, and then returns the names in JSON format.
        /// </summary>
        /// <returns>The names in JSON format</returns>
        /// <param name="amount">How many names to select.</param>
        public string GetDanishNames(int amount)
        {
            SqlExecutor sqlExecutor = new SqlExecutor();
            DataSet dataSet = sqlExecutor.Execute($"SELECT TOP {amount} FirstName,LastName FROM DanishNames");

            string jsonPeople = string.Empty;
            DataRowCollection rows = dataSet.Tables[0].Rows;
            Person[] people = new Person[rows.Count];

            for(int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                people[i] = new Person(row.Field<string>("FirstName"), row.Field<string>("LastName"));
            }

            jsonPeople = JsonConvert.SerializeObject(people);

            // Return json data
            return jsonPeople;
        }

        /// <summary>
        /// Gets all addresses from the Addresses table in the database, and then returns it in JSON format.
        /// </summary>
        /// <returns>Addresses in JSON format</returns>
        public string GetAllAddresses()
        {
            SqlExecutor sqlExecutor = new SqlExecutor();
            DataSet dataSet = sqlExecutor.Execute($"SELECT * FROM Addresses");

            string jsonAddresses = string.Empty;
            DataRowCollection rows = dataSet.Tables[0].Rows;
            Address[] addresses = new Address[rows.Count];

            for(int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                bool isRegionNotNull = !row.IsNull("Region");
                string region = string.Empty;

                if(isRegionNotNull)
                {
                    region = row.Field<string>("Region");
                }

                addresses[i] = new Address(row.Field<string>("StreetName"), row.Field<string>("StreetNumber"), row.Field<string>("ZipCode"), row.Field<string>("City"), region, row.Field<string>("Country"));
            }

            jsonAddresses = JsonConvert.SerializeObject(addresses);

            return jsonAddresses;
        }

        /// <summary>
        /// Gets the specified amount of addresses from the Addresses table in the database, and then returns it in JSON format.
        /// </summary>
        /// <param name="amount">The amount of addresses to get. If the amount is more than what is in the table, then only that amount will be retreived.</param>
        /// <returns>Addresses in JSON format</returns>
        public string GetAddresses(int amount)
        {
            SqlExecutor sqlExecutor = new SqlExecutor();
            DataSet dataSet = sqlExecutor.Execute($"SELECT TOP {amount} * FROM Addresses");

            string jsonAddresses = string.Empty;
            DataRowCollection rows = dataSet.Tables[0].Rows;
            Address[] addresses = new Address[rows.Count];

            for(int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                bool isRegionNotNull = !row.IsNull("Region");
                string region = string.Empty;

                if(isRegionNotNull)
                {
                    region = row.Field<string>("Region");
                }

                addresses[i] = new Address(row.Field<string>("StreetName"), row.Field<string>("StreetNumber"), row.Field<string>("ZipCode"), row.Field<string>("City"), region, row.Field<string>("Country"));
            }

            jsonAddresses = JsonConvert.SerializeObject(addresses);

            return jsonAddresses;
        }
    }
}