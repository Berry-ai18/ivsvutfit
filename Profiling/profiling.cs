using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
// nasa kniznica
using Kniznica;


// Vytvorit pomocou matematickej kniznice(nasej)                        done         
// Vyberova smerodatna odchylka                                         done
// Program cita postupnost cisel z stdin                                done
// nacita aspon 1000 cisel                                              done                              
// priklad spustenia: ./Smerodatna_odchylka < data.txt                  done

// Potom tento program dat do profileru 
// Vstupy velkosti 10,100,1000 cisel                                    done
// Odovzdat vystup profileru, zhrnutie,kde program travi najviac casu
// Do protokolu tiez uviest na co sa zamerat pri optimalizacii kodu
namespace Odchylka
{
    public class Program
    {
        public static void Main()
        {
            var op = new kniznica();
            int count = 0;
            double a_priemer = 0;
            //double pow_artm;
            double sucet = 0;
            double rozdiel = 0;
            string line;
            double[] arr = new double[5000];
           
            while ((line = Console.ReadLine()) != null && line != "\0") {
                
                if(line == null){
                    Console.WriteLine("Nie je vstup");
                }else{
                    string[] cast;

                    // rozdeli string podla whitespace
                    string regex =  "[ ](?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
                    Regex my = new Regex(regex, RegexOptions.Multiline);
                    cast = my.Split(line);

                    // prekonvertuje string na double
                    double num = double.Parse(cast[0]);
                    // ulozime n=ty prvko do pola arr
                    arr[count] = num;
                    // sucet
                    sucet += num;
                    

                    count++;

                    // aritmeticky priemer
                    a_priemer = op.div(sucet,count);

                    // (a_priemer)^2 * count
                    //pow_artm = count * op.exp(a_priemer,2);

                }
               
            }   

            double temp;
            double temp2 = 0;;

            for(int i=0; i < count; i++){
                temp = op.minus(arr[i], a_priemer);
                temp2 = op.exp(temp, 2);
                rozdiel = rozdiel + temp2;
            }

             temp = op.div(rozdiel, (count-1));

            double vysledok = op.sqrt(temp);
            
            Console.WriteLine("Vysledok je: " + vysledok);
   
        }
    }
}
