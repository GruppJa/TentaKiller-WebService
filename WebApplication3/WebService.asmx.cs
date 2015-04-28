using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace WebApplication3
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tentakiller.org/show")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        public SqlConnection con = new SqlConnection("Data Source=localhost;Uid=alle;pwd=hemligt1234;Initial Catalog=TentaKiller12");

        [WebMethod(Description = "Returns Students")]
        public DataSet getStudents()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", con);
            DataSet studentDS = new DataSet();

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(studentDS, "Students");
            return studentDS;
        }
        [WebMethod(Description = "Returns Exams")]
        public DataSet getExams()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Exams", con);
            DataSet examsDS = new DataSet();

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(examsDS, "Exams");
            return examsDS;
        }
        [WebMethod(Description = "Returns Trials")]
        public DataSet getTrials()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Trials", con);
            DataSet trialsDS = new DataSet();

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(trialsDS, "Trials");
            return trialsDS;
        }
    }
}