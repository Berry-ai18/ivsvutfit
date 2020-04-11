using System; 
  
class GFG { 
  
    // Main Method     
    static void Main(string[] args) 
    { 
        string line;
        while ((line = Console.ReadLine()) != null && line != "\0") {
            Console.WriteLine(line);
        }
            
        
        /*String[] spearator = { "\n" }; 
        Int32 count = 2; 
  
        // using the method 
        String[] strlist = line.Split(spearator, count, 
               StringSplitOptions.RemoveEmptyEntries); 
*/

        //Console.WriteLine(strlist);
        /*foreach(String s in strlist) 
        { 
            if(s != null){
            Console.WriteLine(s);
            } 
        } */
    } 
} 