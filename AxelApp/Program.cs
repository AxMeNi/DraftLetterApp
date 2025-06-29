using System;
using System.Threading.Tasks;

// static void main()
// {
//     Console.WriteLine("Provide msg plssss <3");
//     var queue = new Queue<string>();
//     var msg = Console.ReadLine();
//     if (msg == String.Empty)
//     {
//         msg = Console.ReadLine();
//     }
//     var interval_day = new Random().Next(7, 21);
//     var deliver_time = DateTime.Now.AddSeconds(interval_day);
//     while (DateTime.Now < deliver_time)
//     {
//         ;
//     }
//     Console.WriteLine(msg);

// }

async Task main()
{
    await MessagePeople();
}

static async Task<string> MessagePeople()
{
    var a = "You are about to send a message to seomeone";
    Console.WriteLine(a);
    var askingText = AskText();
    var test = await askingText;
    var sendingMessage = SendMessage();
    return a;
}

static async Task<string> AskText()
{
    var b = "b";
    Task.Delay(1000).GetAwaiter().GetResult();
    return b;
}

static async Task<string> SendMessage()
{
    await Task.Delay(1000);
    var c = "c";
    return c;
}