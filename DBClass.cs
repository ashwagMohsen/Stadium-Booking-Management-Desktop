using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Uranus
{
    class DBClass
    {
        static string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
        public static string connectionString = ConfigurationManager.ConnectionStrings["Uranus"].ConnectionString;// + s + "\\DenamoDB.mdf";
        //static string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
        //public static string connectionString = ConfigurationManager.ConnectionStrings["ArmyDB"].ConnectionString;

        public static SqlParameter CreateParameter(string name, object value)
        {
            return new SqlParameter(name, value);
        }

        static SqlCommand CreateCommand(string query, params SqlParameter[] prmArray)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
       
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (!query.Contains(" "))
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (prmArray.Length > 0)
                    sqlCommand.Parameters.AddRange(prmArray);

                sqlConnection.Open();

                return sqlCommand;
         
        }

        public static int ExcuteNonQuery(string query, params SqlParameter[] prmArray)
        {
            SqlCommand sqlCommand = CreateCommand(query,prmArray);

            int affectedRows = sqlCommand.ExecuteNonQuery();

            sqlCommand.Connection.Close();

            return affectedRows;
        }

        public static object ExcuteScalar(string query, params SqlParameter[] prmArray)
        {
            SqlCommand sqlCommand = CreateCommand(query, prmArray);

            object value = sqlCommand.ExecuteScalar();

            sqlCommand.Connection.Close();

            return value;
        }

        public static SqlDataReader ExcuteReader(string query, params SqlParameter[] prmArray)
        {
            using (SqlCommand sqlCommand = CreateCommand(query, prmArray))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return sqlDataReader;
            }
        }

        public static DataTable ExcuteDataTable(string query, params SqlParameter[] prmArray)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
           
            if (!query.Contains(" "))
                sqlDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            if (prmArray.Length > 0)
                sqlDataAdapter.SelectCommand.Parameters.AddRange(prmArray);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            return dt;
        }
  
        public static DataSet ExcuteDataSet(string query, params SqlParameter[] prmArray)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);

            if (!query.Contains(" "))
                sqlDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            if (prmArray.Length > 0)
                sqlDataAdapter.SelectCommand.Parameters.AddRange(prmArray);

            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            return ds;
        }
    }
}
