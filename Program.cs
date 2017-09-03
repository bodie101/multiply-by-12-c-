using System;

namespace home2
{
    class Program
    {
        static void Main(string[] args)
        {
         //Start the program with Clear();
         Console.Clear(); 

         

         Console.WriteLine("what number do you want to times by"); 
         var input1 = Console.ReadLine(); 

         var number1 = 0;  
         var isNumber = int.TryParse(input1, out number1);

         if(isNumber) {

             var counter = 12;

             for (var i = 0; i < counter; i++)
             {
                 var a = i + 1;
                 Console.WriteLine($"{input1} * {a} = {number1 * a} ");
             }

         }
         else {
             Console.WriteLine("please type in a number.");
         }
         






        
              

                          
         
         
            
      

         




         
         //End the program with blank line and instructions
         Console.ResetColor();
         Console.WriteLine();
         Console.WriteLine("Press <Enter> to quit the program");
         Console.ReadKey();   
        }
    }
}
