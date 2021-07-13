using AdonetExample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyWebService
{
    public class Repository
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");//(User Id = sa; Password=123) to connect to database
        public List<EmployeeModel> GetAllEmployee()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("usp_getEmployeeDetailsTest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel empObj = new EmployeeModel();
                empObj.EmpId = Convert.ToInt32(dr[0]);
                empObj.EmpName = Convert.ToString(dr[1]);
                empObj.EmpSalary = Convert.ToInt32(dr[2]);

                listObj.Add(empObj);
            }

            return listObj;
        }
    }
}