using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace BingImageGetter
{
    internal class Dao
    {
        //private const string conStr = @"server=Microsoft.ACE.OLEDB.12.0;Data Source=IMAGEDB.accdb;Persist Security Info=False";
        
        public string headline;
        public string title;
        public string description;
        public string main_text;
        public string copyright;
        public string add_date;
        public string url;

        public string Insert(string headline,
                             string title,
                             string description,
                             string main_text,
                             string copyright,
                             string add_date,
                             string url)
        {
            /* SqlConnection sqlConnection = new SqlConnection();
             sqlConnection.ConnectionString = conStr;
             sqlConnection.Open();
             string sql = "select * from image";
             SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
             int rows=sqlCommand.ExecuteNonQuery();
       */

            /* OleDbConnectionStringBuilder oleString = new OleDbConnectionStringBuilder();
             oleString.Provider = "Microsoft.ACE.OleDB.12.0";
             oleString.DataSource = "IMAGEDB.accdb";
             OleDbConnection conn = new OleDbConnection();
             conn.ConnectionString = oleString.ToString();
             conn.Open();
             OleDbCommand mycmd = new OleDbCommand();
             mycmd.Connection = conn;
             mycmd.CommandText = @"select * from image";
             int rows=mycmd.ExecuteNonQuery();
             conn.Close();
             mycmd.Dispose();
             return rows;*/



            SQLiteConnection sQLiteConnection = new SQLiteConnection("URI=file:IMAGEDB.sqlite");
            sQLiteConnection.Open();
            string sql = "insert into image(id,headline,title,description,main_text,copyright,add_date,url) values(null," + "'"+headline + "'" + "," + "'" + title + "'" + "," + "'" + description + "'" + "," + "'" + main_text + "'" + "," + "'" + copyright + "'" + "," + "'" + add_date + "'" + "," + "'" + url + "'" + ")";
            //return sql;
            SQLiteCommand cmd = new SQLiteCommand(sql, sQLiteConnection);
            int rows= cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                return "Insert OK!";
            }
            else
            {
                return "Insert Failed!";
            }
           
        }
    }
}
