using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Controller
    {
        ServiceReference.WebServiceSoapClient service = new ServiceReference.WebServiceSoapClient();
        public object[] getStudents()
        {
            return service.getStudents();
        }
        public DataSet getExams()
        {
            return service.getExams();  
        }
        public DataSet getTrials()
        {
            return service.getTrials();
        }
    }
}
