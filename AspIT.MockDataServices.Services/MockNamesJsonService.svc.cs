using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using AspIT.MockDataServices.Entities;
using AspIT.MockDataServices.DB;

namespace AspIT.MockDataServices.Services
{
    /// <summary>
    /// Represents a WCF Service that is responsible for returning stuff in JSON format/>
    /// </summary>
    public class MockNamesJsonService : IMockNamesJsonService
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
    }
}