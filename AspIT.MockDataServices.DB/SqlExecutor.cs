using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;

namespace AspIT.MockDataServices.DB
{
    public class SqlExecutor
    {
        private string connectionString;

        public SqlExecutor()
        {
            string connsString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            if(connsString != string.Empty)
            {
                connectionString = connsString;
            }
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
