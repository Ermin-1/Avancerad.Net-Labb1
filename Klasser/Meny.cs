using Avancerad.Net_Labb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avancerad.Net_Labb1.Klasser
{
    internal class Meny
    {


        public static void MenyGo()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("               HUVUDMENY             ");
                Console.WriteLine("=====================================");
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Visa alla lärare som undervisar i matematik");
                Console.WriteLine("2. Visa alla elever och deras respektive lärare");
                Console.WriteLine("3. Kontrollera om kursen 'Programmering 1' finns");
                Console.WriteLine("4. Byt namn på kursen 'Programmering 2' till 'OOP'");
                Console.WriteLine("5. Byt en elevs lärare från Anas till Reidar");
                Console.WriteLine("=====================================");
                Console.WriteLine("Ange ditt val genom att skriva motsvarande siffra.");


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HämtaMatteLärare();
                        break;
                    case "2":
                        LärareMedStudent();
                        break;
                    case "3":
                        Programmering1();
                        break;
                    case "4":
                        ÄndraTillOOP();
                        break;
                    case "5":
                        AnasTillReidar();
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val");
                        break;
                }

                Console.WriteLine("Klicka för att fortsätta");
                Console.ReadKey();
                Console.Clear();
            }
        }


        public static void HämtaMatteLärare()
        {
            using SkolaDbContext context = new SkolaDbContext();
            var lärare = context.Kopplingstabeller.Where(t => t.ÄmneId == 1)
                .Select(t => t.Lärare.LärarNamn).Distinct().ToList();
            foreach (var item in lärare)
            {
                Console.WriteLine(item);
            }
        }

        public static void LärareMedStudent()
        {
            using SkolaDbContext context = new SkolaDbContext();
            var lärareMedStudent = from l in context.Kopplingstabeller
                                   join Lärare in context.Lärare on l.LärarId equals Lärare.LärarId
                                   join Student in context.Studenter on l.StudentId equals Student.StudentId
                                   select new
                                   {
                                       StudentId = Student.StudentId,
                                       StudentNamn = Student.StudentNamn,
                                       LärarNamn = Lärare.LärarNamn
                                   };

            foreach (var student in lärareMedStudent)
            {
                Console.WriteLine($"Student ID: {student.StudentId}, Student: {student.StudentNamn}, Lärare: {student.LärarNamn}");
            }
        }

        public static void Programmering1()
        {
            using SkolaDbContext context = new SkolaDbContext();
            var p1 = context.Ämnen.FirstOrDefault(obj => obj.ÄmneNamn == "Programmering1");

            if (p1 != null)
            {
                Console.WriteLine("Programmering1 finns i listan");
            }
            else
            {
                Console.WriteLine("Programmering1 finns inte i listan.");
            }
        }

        public static void ÄndraTillOOP()
        {
            using SkolaDbContext context = new SkolaDbContext();
            var oop = context.Ämnen.FirstOrDefault(o => o.ÄmneNamn == "Programmering2");

            if (oop != null)
            {
                oop.ÄmneNamn = "OOP";
                context.SaveChanges(); 
            }
            Console.WriteLine("Ämnet Programmering2 har bytt namn till OOP");

            Console.WriteLine("--------------------");
            var ämnen = context.Ämnen.ToList();
            foreach (var item in ämnen)
            {
                Console.WriteLine("ID{0} - Kursnamn = {1}", item.ÄmneId, item.ÄmneNamn);
            }

        }

        public static void AnasTillReidar()
        {
            using SkolaDbContext context = new SkolaDbContext();


            var namnByte = from a in context.Kopplingstabeller
                                       join lärare in context.Lärare on a.LärarId equals lärare.LärarId
                                       join student in context.Studenter on a.StudentId equals student.StudentId
                                       where lärare.LärarNamn == "Anas"
                                       select new
                                       {
                                           StudentId = student.StudentId,
                                           StudentNamn = student.StudentNamn,
                                           LärarNamn = lärare.LärarNamn
                                       };

            foreach (var student in namnByte)
            {
                Console.WriteLine($"Student ID: {student.StudentId}, Student: {student.StudentNamn}, Teacher: {student.LärarNamn}");
            }

            
            Console.WriteLine("Vilket studentid vill du ändra lärare på?");
            int choice = Convert.ToInt32(Console.ReadLine());

            var väljStudent = context.Kopplingstabeller.FirstOrDefault(s => s.StudentId == choice);
            if (väljStudent != null)
            {
                var reidar = context.Lärare.FirstOrDefault(r => r.LärarNamn == "Reidar");
                if (reidar != null)
                {
                    väljStudent.LärarId = reidar.LärarId;
                    Console.WriteLine("Elevens lärare är uppdaterad till Reidar.");
                    context.SaveChanges(); 
                }
                else
                {
                    Console.WriteLine("Reidar finns ej ");
                }
            }
            else
            {
                Console.WriteLine("Fel studentid");
            }

        }




    }
}
