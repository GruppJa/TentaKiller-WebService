using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Configuration;
using WebApplication3;

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
        SqlConnection con = new SqlConnection(DatabaseConnection.ConnectionString);

        [WebMethod(Description = "Returns Students")]
        public List<String[]> getStudents()
        {
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Name, Email FROM Students ORDER BY Name ASC", con);
                DataSet studentDS = new DataSet();

                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adapter.Fill(studentDS, "Students");

                con.Close();

                List<String[]> list = new List<String[]>();

                foreach (DataRow row in studentDS.Tables[0].Rows)
                {
                    list.Add(new String[3] { (String)row.ItemArray.GetValue(0), (String)row.ItemArray.GetValue(1), (String)row.ItemArray.GetValue(2) });
                }
                return list;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}