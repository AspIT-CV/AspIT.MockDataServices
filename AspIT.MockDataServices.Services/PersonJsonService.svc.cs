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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PersonJsonService : IPersonJsonService
    {
        public string GetAllPeople()
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