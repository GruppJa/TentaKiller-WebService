using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Configuration;

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
        //private string con = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(DatabaseConnection.ConnectionString);

        [WebMethod(Description = "Returns Students")]
        public DataSet getStudents()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Name, Email FROM Students ORDER BY Name ASC", con);
            DataSet studentDS = new DataSet();

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(studentDS, "Students");

            con.Close();
            return studentDS;
        }
        /*[WebMethod(Description = "Returns Students")]
        public object[] getStudents()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Name, Email FROM Students ORDER BY Name ASC", con);
            DataSet studentDS = new DataSet();

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(studentDS, "Students");

            con.Close();
            int i = 0;
            object[] list = new object[studentDS.Tables[0].Rows.Count];

            foreach (DataRow row in studentDS.Tables[0].Rows)
            {
                list[i++] = row.ItemArray;
            }
            return list;
        }*/
        [WebMethod(Description = "Returns Exams")]
        public DataSet getExams()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Exams", con);
            DataSet examsDS = new DataSet();

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(examsDS, "Exams");
            con.Close();
            return examsDS;
        }
        /*public class Students {
        
            public string Name {get; set;}
            public string Id {get; set;}
            public string Email {get; set;}
            }
        
        [WebMethod(Description = "returns list of students")]
        {
            try {
                 SqlCommand query = new SqlCommand("SELECT Id, Name, Email FROM Students ORDER BY Name ASC");
                
                List<Students> StudentsList = new List<Students>();
                foreach(TentaKillerWebApplication. in query) {}
                }
    }*/
        /*[WebMethod(Description = "Returns Trials")]
        public DataSet getTrials()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Trials", con);
            DataSet trialsDS = new DataSet();

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(trialsDS, "Trials");
            con.Close();
            return trialsDS;
        }*/
    }
}