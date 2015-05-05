using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;
using WindowsFormsApplication1;

 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ServiceReference.WebServiceSoapClient service = new ServiceReference.WebServiceSoapClient();
        Controller controller = new Controller();        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TrialsButton_Click(object sender, EventArgs e)
        {
            //DataSet ds = controller.getTrials();
            //dataGridView.DataSource = ds.Tables[0];
        }
        private void StudentsButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Name";
            dataGridView.Columns[2].Name = "Email";
            String[][] ds = controller.getStudents();
            for (int i = 0; i < ds.Length; i++) { 
                dataGridView.Rows.Add(ds[i]);
            }
        }
        private void ExamsButton_Click(object sender, EventArgs e)
        {
            DataSet ds = controller.getExams();
            dataGridView.DataSource = ds.Tables[0];
        }
    }
}



                   
    
        
    

