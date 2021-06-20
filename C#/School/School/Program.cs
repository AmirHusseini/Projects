using System;

namespace School
{
    class student
    {
        public int studentID { get; set; }
        public string studentname { get; set; }
        public string studentaddress { get; set; }

        public void showinfo ()
        {
            Console.WriteLine($"Student's informtation: \n Student's ID: {studentID} \n Name: {studentname} \n Address: {studentaddress}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student sc = new student();
            sc.studentID = 1;
            sc.studentname = "Jack";
            sc.studentaddress = "California";

            sc.showinfo();
        }
    }
}
