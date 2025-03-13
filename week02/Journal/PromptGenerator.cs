
public class PromptGenerator{
    public List<string> _prompt = new List<string>();
 
  
  public string GetRandomPrompt(){

     Random rand = new Random();
         string _randomItem = _prompt[rand.Next(_prompt.Count)]; 
        
    
    return _randomItem;
    }
}