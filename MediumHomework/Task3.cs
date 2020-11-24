using System;

namespace MediumHomework
{


    enum Universities
    {
        OGTU,
        MGU,
        NGU,
        NGTU,
        OGU

    }


    struct Employe
    {
        public string Firstname;
        public string Secondname;
        public int salary;
        public Universities Univer;


        public void ShowData () {
            Console.WriteLine($">>>>>{Firstname}");
            Console.WriteLine($">>>>>{Secondname}");
            Console.WriteLine($">>>>>{salary}");
            Console.WriteLine($">>>>>{Univer}");
        }   



    }


    class Task3
    {
        static void Main(string[] args)
        {
            Employe emp;
            emp.Firstname = "Somename";
            emp.Secondname = "Somesecondname";
            emp.salary = 25000;
            emp.Univer = Universities.OGTU;
            emp.ShowData();


        }
    }
}
