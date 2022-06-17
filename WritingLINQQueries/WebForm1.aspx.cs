using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WritingLINQQueries
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Student> queryResult = from student in Student.GetAllStudents()

                                               where student.Gender == "Male"
                                               select student;
            GridView1.DataSource = queryResult;
            GridView1.DataBind();
        }
    }
}