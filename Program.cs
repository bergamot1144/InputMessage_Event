
string message = "this text is for testing событие in my program";
MessageHandler handler = new MessageHandler();

handler.OnEventOccured += () =>
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Событие произошло!");
    Console.ResetColor();
};


handler.CheckMessage(message);



public delegate void EventOccured();

public class MessageHandler
{
    public event EventOccured OnEventOccured;

    public void CheckMessage(string message)
    {
        string[] wordsInMessage = message.Split(' ');


        foreach (string word in wordsInMessage)
        {

            if(word == "событие")
            {
                if (OnEventOccured != null)
                {
                    OnEventOccured.Invoke();
                }
            }
            else
            {
                Console.WriteLine($"{word} - Не найдено");
            }
        }
    }

}