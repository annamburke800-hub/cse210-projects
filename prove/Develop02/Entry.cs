using System; 
public class Entry 
{
    static DateTime theCurrentTime = DateTime.Now;
    static DateTime datePartOnly = theCurrentTime.Date;


    public static Prompts _prompts = new Prompts();
    public string _prompt = _prompts.RandomizePrompt();
    public string _response;
    public string _date = datePartOnly.ToString("MM/dd/yyyy");

    public override string ToString()
    => $"Date: {_date} Prompt: {_prompt}\n Response: {_response}";

    public string ToLine() => $"{_date}|{_prompt}|{_response}";

    public static Entry FromLine(string line)
    {
        var parts = line.Split('|');
        if (parts.Length < 3) return new Entry(); //For my info: this will help the program not to crash if by any reason, there are less than 3 parts on the entry. 
        return new Entry
        {
            _date = parts[0],
            _prompt = parts[1],
            _response = parts[2]
        };
    }




     

} 