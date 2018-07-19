using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {


            try
            {
                string conString = "User Id=testUser;Password=1234;" + "Data Source=115.159.160.215:1521/orcl;";
                string ConnectString = "Data Source=115.159.160.215:1521/orcl;User ID=c##testUser;PassWord=1234";//
                OracleConnection conn = new OracleConnection(ConnectString);
                conn.Open();
                string queryString = "SELECT * FROM T_USER";
                OracleCommand cmd = conn.CreateCommand();
                                           cmd.BindByName = true;

                //Use the command to display employee names from 
                // the EMPLOYEES table
                cmd.CommandText = "select * from testtable1";
               
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                  String a= "id:" + reader["ID"] + "\n";
                

                reader.Close();
                conn.Close();
                return a;
            }
            catch(Exception e)
            {
                return e.ToString();
            }
            
        }
    }
}