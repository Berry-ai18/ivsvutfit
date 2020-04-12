using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Math_Library;
// nasa kniznica




// Vytvorit pomocou matematickej kniznice(nasej) 
// Vyberova smerodatna odchylka
// Program cita postupnost cisel z stdin 
// nacita aspon 1000 cisel
// priklad spustenia: ./Smerodatna_odchylka < data.txt

// Potom tento program dat do profileru 
// Vstupy velkosti 10,100,1000 cisel
// Odovzdat vystup profileru, zhrnutie,kde program travi najviac casu
// Do protokolu tiez uviest na co sa zamerat pri optimalizacii kodu
namespace Smerodatna_Odchylka
{
    public class Smerodatna_Odchylka
    {
        public static int Vypocet(string vstup)
        {
            double num = double.Parse(vstup);
            var obj = new Math_lib();
            double res = absh.abs(num); 

            Console.WriteLine("Cislo je: " + num);
            return 0;
        }
        public static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != null && line != "\0") {

                if(line == null){
                    Console.WriteLine("Nie je vstup");
                }else{
                    string[] cast;
                    string regex =  "[ ](?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
                    Regex my = new Regex(regex, RegexOptions.Multiline);
                    cast = my.Split(line);

                    Vypocet(cast[0]);

                    //Console.WriteLine("Vysledok: " + cast[0]);
                }

            }
        }
    }
}
