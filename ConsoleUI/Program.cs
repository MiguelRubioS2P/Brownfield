using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t, ttl;
            bool cont = false;
            string consoleValue;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            //Console.Write("Enter what you did: ");
            //w = Console.ReadLine();
            //Console.Write("How long did you do it for: ");
            //t = int.Parse(Console.ReadLine());
            
            //ent.HoursWorked = t;
            //ent.WorkDone = w;
            //ents.Add(ent);
            //Console.Write("Do you want to enter more time:");
            //No se puede convertir el valor recibido por consola que es string en boleano
            //bool cont = bool.Parse(Console.ReadLine());
            //Creo una variable string y trato este string, se puede poner en una funcion.
            //De todas maneras un cambio funcional es una función dentro del do para que se repita y no tenerlo dos veces
            //consoleValue = Console.ReadLine();
            //if (consoleValue == "yes")
            //{
            //    cont = true;
            //}
            //else if (consoleValue == "no")
            //{
            //    cont = false;
            //}

            //Dejamos arriba las creaciones de las variables necesarias.
            do
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                t = int.Parse(Console.ReadLine());
                TimeSheetEntry ent = new TimeSheetEntry();
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);
                Console.Write("Do you want to enter more time:");
                //Controlamos manualmente la entrada por consola
                consoleValue = Console.ReadLine();
                if (consoleValue == "yes")
                {
                    cont = true;
                }
                else if(consoleValue == "no")
                {
                    cont = false;
                }
            } while (cont == true);
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                //Acme tiene que ponerse en Mayúsculas 
                if (ents[i].WorkDone.Contains("ACME"))
                {
                    ttl += ents[i].HoursWorked; ;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");
            int help = 0;
            help = ttl;
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ABC"))
                {
                    ttl += ents[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
