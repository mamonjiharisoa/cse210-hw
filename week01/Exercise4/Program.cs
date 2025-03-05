using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
       
                
                int New_number ;
                List<int> Number = new List<int>();
              

                while (true) {Console.Write(" Add a number ");
                 New_number = int.Parse(Console.ReadLine());

                 

                 if (New_number != 0) {
                    Number.Add(New_number);
                    }
                 else if (New_number == 0) {
                    break;
            }  }

                 
           // Console.WriteLine(string.Join(", ", Number));


            int Maxi; 
            Maxi = 0;
            foreach (int num in Number){
            if (num > Maxi ) {
                Maxi = num;
            }}
         

        int Number_inside = Number.Count;
         

        float total = Number.Sum();

        float Average;
        Average = total/Number_inside;
        Console.WriteLine ($"The sum is:{total}");
        Console.WriteLine($"The Average is :{Average}");
        Console.WriteLine($"The Largest number is :{Maxi}");



               





}
}