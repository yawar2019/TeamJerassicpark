using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AdonetExample.Models
{
    public class EmployeeModel
    {
        public int? EmpId { get; set; }
        public string EmpName { get; set; }
        public int? EmpSalary { get; set; }
    }

    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");//(User Id = sa; Password=123) to connect to database
        public List<EmployeeModel> GetAllEmployee()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("usp_getEmployeeDetailsTest",con);
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

        public int SaveEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_insertRituEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName",emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary",emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public EmployeeModel getEmployeeById(int? EmpId )
        {
             EmployeeModel EmpObj = new EmployeeModel();

            SqlCommand cmd = new SqlCommand("sp_RajagetEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", EmpId);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpObj.EmpId = Convert.ToInt32(dr[0]);
                EmpObj.EmpName = Convert.ToString(dr[1]);
                EmpObj.EmpSalary = Convert.ToInt32(dr[2]);
                 
            }

            return EmpObj;
        }

        public int UpdateEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_RajaUpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@EmpId",emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName",emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary",emp.EmpSalary);

            int i = cmd.ExecuteNonQuery();
            con.Close();

            return i;
        }
    }
}