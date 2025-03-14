 using System.IO;
public class Journal{

public List<Entry> _entries = new List<Entry>();

public List<string> _entries_1 = new List<string>();


public void Add(Entry newEntry){
   
 
 _entries.Add(newEntry);
 
 Console.WriteLine("we add it ");

 
 
}

        

public void Displayall()
{
   foreach (string line in _entries_1) {
   
   Console.WriteLine(line);
    
   }



 

 foreach ( var entry in _entries){
 
 Console.WriteLine($"Date:{entry._date} - Time: {entry._time}    prompt:{entry._promptText}");
 Console.WriteLine($"{entry._entryText}");
 Console.WriteLine();
 }
 
}
public void SaveToFile(string File){
 
 using(StreamWriter outputFile = new StreamWriter(File))
   
    {
   foreach (var entry in _entries)
   {
 
   outputFile.WriteLine($"Date:{entry._date} - Time: {entry._time}     prompt:{entry._promptText}");
   outputFile.WriteLine($"{entry._entryText}");

    }
    
}}


public void LoadfromFile(string File) {

string[] lines = System.IO.File.ReadAllLines(File);

}  




}
   
 




     
  
  
 






     
   




