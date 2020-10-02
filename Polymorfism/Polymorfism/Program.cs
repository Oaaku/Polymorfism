using System;

namespace Polymorfism
{
    class Person
    {
        public virtual void name()
        {
            Console.WriteLine("Name");
        }
        public virtual void telefon()
        {
            Console.WriteLine("Telefon");
        }
    }

    class Student : Person
    {
        public override void name()
        {
            Console.WriteLine("Namn: ILoveKumaBear");
        }
        public override void telefon()
        {
            Console.WriteLine("1235249");
        }
    }

    class Teacher : Person
    {
        public override void name()
        {
            Console.WriteLine("Namn: DenisBlaster");
        }
        public override void telefon()
        {
            Console.WriteLine("802136");
        }
    }

    class Staff : Person
    {
        public override void name()
        {
            Console.WriteLine("Namn: MyMemeisTrue");
        }
        public override void telefon()
        {
            Console.WriteLine("123768");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person someone = new Person();

            someone.name();

            Person myStudent = new Student();
            Person myTeacher = new Teacher();
            Person myStaff = new Staff(); 
            
            myStudent.name();
            myTeacher.name();
            myStaff.name();

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            Person[] Persons = new Person[4];
            
            Persons[0] = new Student();
            Persons[1] = new Teacher();
            Persons[2] = new Staff();

            foreach (Person info in Persons)
            {
                info.name();
            }

            Console.ReadLine();
        }
    }
}

