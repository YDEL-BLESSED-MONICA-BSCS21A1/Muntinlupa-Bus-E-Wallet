using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public static class DatabaseConnection
    {
        public static OleDbConnection cn = new OleDbConnection();
        public static OleDbCommand cmd;
        public static OleDbDataReader dr;
        public static string sql;

        public static void Connect()
        {
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();

                // Use AppDomain.CurrentDomain.BaseDirectory for Console or WPF applications
                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\MBEWDB.accdb";
                cn.Open();
                MessageBox.Show("Database connection opened successfully!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Disconnect()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
                MessageBox.Show("Database connection closed successfully!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
