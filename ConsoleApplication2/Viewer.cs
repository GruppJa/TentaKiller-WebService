using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Viewer
    {
        String choice = null;
        public void Choices()
        {
            
            while (choice != "exit")
            {
                Console.WriteLine("Available table names: Students, Exams, Trials");
                Console.WriteLine("Write table name to show data from it: ");

                choice = Console.ReadLine();

                Controller controller = new Controller();

                if (choice == "Students")
                {
                    controller.getStudents();
                }
                else if (choice == "Exams") {
                    controller.getExams();
                }
                else if (choice == "Trials") {
                    controller.getTrials();
                }
            }
        }
    }
}
