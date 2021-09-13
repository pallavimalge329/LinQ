using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //string conn = System.Configuration.ConfigurationManager.ConnectionStrings["LinqToSQLDBConnectionString"].ToString();

            

            string conn = "Data Source = DESKTOP-N5QBMVO\\SQLEXPRESS; Initial Catalog=TQdb; Integrated Security= true";
            var dc = new EmployeeDataContext(conn);
            Student newStudent = new Student();
            newStudent.studentid = 7;
            newStudent.studentname = "Jyoti";
            dc.Students.InsertOnSubmit(newStudent);
            dc.SubmitChanges();
        }
    }
}
