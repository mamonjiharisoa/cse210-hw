using System;

class Program
{
    static void Main(string[] args)
    {
        
   static  void DisplayWelcome()
   {
      Console.WriteLine("Welcome to the Program");
  }
 
  DisplayWelcome();

   static string PromptUserName() {

    Console.Write(" Please Enter your name ");
     string Name = Console.ReadLine();

     return Name ;
   }

   string Name =  PromptUserName();

   static int PromptUserNumber() {
     Console.Write("What is your favorite number ");
      int Favorite =  int.Parse(Console.ReadLine());

      return Favorite; }

    int Favorit = PromptUserNumber();

    static int SquareNumber( int Favorit) {

      int square;
      square = Favorit * Favorit;

      return square;
    }
     
    int square = SquareNumber(Favorit);


    static void DisplayResult(string Name, int Favorit ,int square ) {

      Console.WriteLine($"{Name} your favorite is {Favorit} and the square of your number is {square} ");
    } 
    
     DisplayResult(Name, Favorit, square);}
}