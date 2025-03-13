 using System.IO;
public class Journal{

public List<Entry> _entries = new List<Entry>();


public void Add(Entry newEntry){
   
 _entries.Add(newEntry);
 
 Console.WriteLine("we add it ");
}

        

public void Displayall()
{
  
 

 foreach ( var entry in _entries){
 
 Console.WriteLine($"Date:{entry._date} - prompt:{entry._promptText}");
 Console.WriteLine($"Text: {entry._entryText} ");
 }
 
}
public void SaveToFile(string File){
 
 using(StreamWriter outputFile = new StreamWriter(File))
   
    {
   foreach (var entry in _entries)
   {
 
   outputFile.WriteLine($"Date:{entry._date} - prompt:{entry._promptText}");
   outputFile.WriteLine($"{entry._entryText}");

    }
    
}}


public void LoadfromFile(string File) {





string[] lines = System.IO.File.ReadAllLines(File);

foreach ( string line in lines   ){

 

    Console.WriteLine(line);
}  




}
   
 



}
     
  
  
 






     
   




