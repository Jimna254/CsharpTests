using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LearningC_.Classes_to_Test;
using Assert = NUnit.Framework.Assert;

namespace MyTestcases
{
    [TestFixture]
    public class Trainees_Tests
    {
        private Trainees? _trainee;

        [SetUp]
        
        public void  setUp()
        {
            _trainee = new Trainees();
        }

        // if input is string- add student
        //if name exists -throw an error

        // if input is ""
        // if name is null -throw an error
        //if input  "   " --throw an error


       
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("                         ")]
        public void AddStudent_CalledwithEmptyorNullorWhiteSpaces_ThrowAnError(string input)
        {
            Assert.That(() => _trainee?.addStudent(input),
          Throws.Exception.TypeOf<ArgumentNullException>().With.Message.Contain("name is Required"));
        }

        [Test]
        public void AddStudent_WithValidName_AddName()
        {

            _trainee.addStudent("James");
            _trainee.addStudent("Yvonne");
            Assert.That(_trainee?.student_count, Is.EqualTo(2));

            //Assert.That(_trainee._studentList ,
            //  Is.EquivalentTo(new List<string>() { "Queens", "Yvonne" }));
        }

        [Test]
        public void AddStudent_WithValidNameBut_Already_Exists_AddName()
        {

            _trainee?.addStudent("James");
            _trainee?.addStudent("Yvonne");

            //Assert.That(_trainee.student_count, Is.EqualTo(2));

            Assert.That(() => _trainee?.addStudent("James"), Throws
                .Exception.TypeOf<InvalidOperationException>().With.Message.Contain("You Cant Add the same name ,more than Once")); ;
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("                         ")]
        public void RemoveStudent_CalledwithEmptyorNullorWhiteSpaces_ThrowAnError(string input)
        {
            Assert.That(() => _trainee?.removeStudent(input),
          Throws.Exception.TypeOf<ArgumentNullException>().With.Message.Contain("name is Required"));
        }
        [Test]
        public void RemoveStudent_WithValidName_RemoveName()
        {

            _trainee?.addStudent("James");
            _trainee?.addStudent("Yvonne");
            _trainee?.removeStudent("Yvonne");
            //Assert.That(_trainee.student_count, Is.EqualTo(2));
            Assert.That(_trainee?.student_count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveStudent_WithUnexistingName_ThrowAnError()
        {


            _trainee?.addStudent("Queens");
            _trainee?.addStudent("Yvonne");

            //Assert.That(_trainee.student_count, Is.EqualTo(2));

            Assert.That(() => _trainee?.removeStudent("Brian"), Throws
                .Exception.TypeOf<InvalidOperationException>().With.Message.Contain("name does not Exist"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("                         ")]
        public void SearchTrainee_WhenCalledEmptyorNull_Throw(string input)
        {
            Assert.That(() => _trainee?.SearchStudent(input),
          Throws.Exception.TypeOf<ArgumentNullException>().With.Message.Contain("Name is Required"));
        }


        [Test]
        [TestCase("James", "James")]
        [TestCase("Wesley", "")]
        public void SearchTrainee_WhenCallednameExist_ReturnName(string input, string output)
        {

            _trainee?.addStudent("James");
            _trainee?.addStudent("Yvonne");

            var results = _trainee?.SearchStudent(input);
            Assert.That(results, Is.EqualTo(output));
        }

    }

}

