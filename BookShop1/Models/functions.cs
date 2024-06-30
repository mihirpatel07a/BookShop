using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;



namespace BookShop.Models
{


    public class functions
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private String constr;
        public functions()
        {
            constr = WebConfigurationManager.ConnectionStrings["bookconnection"].ConnectionString;
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        
            
        }

        public DataTable GetData(string Query)
        {
        
            dt = new DataTable();
            sda = new SqlDataAdapter(Query,  constr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
                cmd.CommandText = Query;
                cnt = cmd.ExecuteNonQuery();
                con.Close();
                return cnt;
        }

    }
}