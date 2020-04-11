using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

public class Decoder {
    public static void Main() {

       string line;

       while ((line = Console.ReadLine()) != null ) {
            Console.WriteLine(line);
        }

       
        
        char[] vzor = new char[] {' '};
        string[] number;
        number = line.Split(vzor, StringSplitOptions.None);
        Console.WriteLine(number[0]);
    }
}