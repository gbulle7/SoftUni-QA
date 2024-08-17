using System;
namespace IntheritanceDemo
{
	public class Student : Person
	{
        //наследени характеристики: name, address
        //собствени характеристики: universityName
        private string universityName;

        //наследени пропъртита: Name, Address
        //собствени пропъртита: UniversityName
        public string UniversityName { get; set; }


        //наследени методи: Talk
        //собствен метод: GoToUniversity
        public void GoToUniversity ()
        {
            Console.WriteLine("Go to " + this.UniversityName);
            base.Talk("Test");
        }

        //наследен конструктор
        public Student (string name, string address, string university) : base(name, address)
        {
            //нов празен обект
            //name = null
            //address = null
            //universityName = null
            this.UniversityName = university;

        }
    }
}

