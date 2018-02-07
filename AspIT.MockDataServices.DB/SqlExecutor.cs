using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AspIT.MockDataServices.DB
{
    public class SqlExecutor
    {
        private string connectionString;

        public SqlExecutor()
        {
            connectionString = @"Data Source = CVDB3, 1444; Initial Catalog = MockDataDB; Integrated Security = True;";
        }

        public DataSet Execute(string sql)
        {
            DataSet dataSet = new DataSet();
            using(SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(sql, new SqlConnection(connectionString))))
            {
                adapter.Fill(dataSet);
            }

            return dataSet;
        }
    }
}
