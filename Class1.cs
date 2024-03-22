using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Employee_Details;
class Class1
{
    public SqlConnection con = new SqlConnection();
    public SqlCommand cmd = new SqlCommand();
    public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Employee_Details\Database1.mdf;Integrated Security = True";
}