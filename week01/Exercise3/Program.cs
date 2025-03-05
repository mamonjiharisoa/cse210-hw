using System;

class Program
{
    static void Main(string[] args)
    {

             int answer = 18;
             int Your_answer ;
             
             Console.WriteLine("What is the magic number 18");
             
             while (true) {
             
              Console.Write("What is your guess ");
             Your_answer = int.Parse(Console.ReadLine());

             if (answer > Your_answer ){
               Console.WriteLine("Higher");
               }
             else if ( Your_answer > answer){
               Console.WriteLine("Lower"); 
             }
             else {
               Console.WriteLine("you guessed it");
                  break;
             }

            
             } 
             

             
 }        
}