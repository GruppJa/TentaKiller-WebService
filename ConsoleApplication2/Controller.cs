using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApplication2
{
    class Controller
    {
        ServiceReference.WebServiceSoapClient client = new ServiceReference.WebServiceSoapClient();
        public void getStudents()
        {
            //DataTable studentsTable = new DataTable();

            //DataSet ds = client.getStudents();
            //studentsTable = ds.Tables["Students"];

            String[][] students = client.getStudents();

            //Console.WriteLine(studentsTable.Rows.Count);
            
            foreach (String[] dataRow in students)
            {
                foreach (String s in dataRow)
                {
                    Console.WriteLine();
                    Console.WriteLine(s);
                }
                Console.WriteLine("---------------");
            }
        }
        /*public void getExams()
        {
            DataTable examsTable = new DataTable();

            DataSet ds = client.getExams();
            examsTable = ds.Tables["Exams"];

            Console.WriteLine(examsTable.Rows.Count);
            foreach (DataRow dataRow in examsTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                }
            }
        }*/
        /*public void getTrials()
        {
            DataTable trialsTable = new DataTable();

            DataSet ds = client.getTrials();
            trialsTable = ds.Tables["Trials"];

            Console.WriteLine(trialsTable.Rows.Count);
            foreach (DataRow dataRow in trialsTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                }
            }
        }*/
    }
}
