﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.UI.WebControls;

namespace LMS_ProjectTraining
{
    public class DBConnect
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        public SqlConnection GetCon()
        {
            return con;
        }

        public void OpenCon()
        {
            if(con.State==ConnectionState.Closed)
                con.Open();
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}