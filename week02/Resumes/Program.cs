using System;

class Program
{
    static void Main(string[] args)
    {
      Job job1 = new Job();  
      Job job2 = new Job();
       
       job1._jobTitle ="Software Engineer";
       job1._Company ="Apple";
       job1._startYear = 2019; 
       job1._endYear = 2022;

       job2._jobTitle ="Manager";
       job2._Company ="Microsoft";
       job2._startYear = 2017; 
       job2._endYear = 2023;
      


       job1.Display();
       job2.Display();
      

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        Console.WriteLine(job1);
        Console.WriteLine(job2);

         myResume.Display();

       
    }

    
       
    }
