public class Entry{
    public string _date;
    public string _promptText;

    public string _entryText;
    
    public string _time;


    public void Display(){
    
    Console.WriteLine( $"Date:{_date} , Time {_time} - Prompt : {_promptText} ");

    Console.WriteLine($"{_entryText}" );
     }
}

