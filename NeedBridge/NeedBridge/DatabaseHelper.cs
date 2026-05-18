using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NeedBridge
{
    public class DatabaseHelper
    {
        // Gets connection string from App.config
        private static string connectionString = ConfigurationManager
            .ConnectionStrings["NeedBridgeDB"].ConnectionString;

        // Opens and returns a connection to NeedBridgeDB
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Runs INSERT, UPDATE, DELETE queries
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        // Runs SELECT queries and returns a table of data
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Returns a single value (like COUNT or SUM)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }
    }
}