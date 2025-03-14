// I add a Time for the excedind requirment // 

 using System.IO;
 using System;


class Program
{
    static void Main(string[] args)
    {
      
    

     PromptGenerator AddList = new PromptGenerator();
      AddList._prompt.Add("Who was the most interesting person I interacted with today?");
      AddList._prompt.Add("What was the best part of my day?");
      AddList._prompt.Add("How did I see the hand of the Lord in my life today?");
      AddList._prompt.Add("What was the strongest emotion I felt today?");
      AddList._prompt.Add("If I had one thing I could do over today, what would it be?");

     
      Journal AddList_1 = new Journal(); 

      
        
      
      while (true){

     Console.WriteLine("1.Write");
     Console.WriteLine("2.Display");
     Console.WriteLine("3.Load");
     Console.WriteLine("4.Save");
     Console.WriteLine("5.Quit");

     Console.Write("What is your choice? ");
     int choicei = int.Parse(Console.ReadLine());

     if (choicei == 1 ){  
         
      Entry newEntry = new Entry();
      newEntry._promptText = AddList.GetRandomPrompt();
      newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
      newEntry._time =  DateTime.Now.ToString("HH:mm:ss");
      

      Console.WriteLine(newEntry._promptText);
      newEntry._entryText = Console.ReadLine();
      AddList_1.Add(newEntry);
      
      
}
  

     else if(choicei == 2){
     
      AddList_1.Displayall();
     
     }  
     

     else if (choicei == 3 ){

       Console.WriteLine("What is the name of the file");
       string File = Console.ReadLine();

       AddList_1.LoadfromFile(File);

;
 

     }

     else if (choicei == 4) {

   Console.WriteLine("What is the name of the file");
   string File = Console.ReadLine();

     AddList_1.SaveToFile(File); } 

     else if (choicei == 5) { 
      
      break;

     }
}}}
      



        


     
      
      
      
      
      
      
      
      
      
       





        
        
          
    
