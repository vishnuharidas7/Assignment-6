using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace GridView.DAL
{
    public class Dept_Dal
    {

        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Dept_Dal()
        {
            //conection string in web.config
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int departmentInsert(BAL.Dept_Bal obj)
        {
            string qry = "insert into tbl_department values('" + obj.DepartName + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable viewDepartment()
        {
            string qry = "select * from tbl_department ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;

        }

        public int updateDepartment(BAL.Dept_Bal obj)
        {
            string s = "update tbl_department set department_name = '" + obj.DepartName + "' where department_Id = '" + obj.Departmentid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int deletedepartment(BAL.Dept_Bal obj)
        {
            string s = "Delete from tbl_department where department_Id = '" + obj.Departmentid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }



    }
}