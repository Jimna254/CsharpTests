using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Classes_to_Test
{
    public class Trainees
    {
        private List<string> studentList = new List<string>();
        public int student_count => studentList.Count;

        // if input is string- add student
        //if name exists -throw an error

        // if input is ""
        // if name is null -throw an error
        //if input  "   " --throw an error


        public void addStudent(string studentName)
        { //null checking
            if (string.IsNullOrWhiteSpace(studentName))
            {
                throw new ArgumentNullException("name is Required");

                var student = studentList.Find(x => x == studentName);
                if (student == null) { 
                
                    studentList.Add(studentName);
                    return;
                }
                throw new InvalidOperationException("You Cant Add the same name ,more than Once");
            }
            // if input is string- add student
            //if name exists -throw an error

            // if input is ""
            // if name is null -throw an error
            //if input  "   " --throw an error


        }
        public void removeStudent(string studentName) {
            //null checking
            if (string.IsNullOrWhiteSpace(studentName))
                throw new ArgumentNullException("name is Required");

            var student = studentList.Find(x => x ==studentName); if (student != null)
            {
                studentList.Remove(studentName);
                return;
            }

            throw new InvalidOperationException("name does not Exist");
        }
   
    public string SearchStudent(string studentName)
        {
            //null checking
            if (string.IsNullOrWhiteSpace(studentName))
                throw new ArgumentNullException("Name is Required");
            
            var name = studentList.Find(x => x == studentName);
            if (name != null) { 
            
            return name;
            
            }
            return string.Empty;
        }
    
    }


}
