
// // dotnet add package Newtonsoft.Json 


string token = File.ReadAllText("token.config");

TelegramBot bot = new TelegramBot(token);

void Updates(TelegramMessageModel msg)
{
    bot.SendMessage(msg.chatId, $"{msg.text}: получено");
}

bot.action = Updates;

bot.Start();

System.Console.WriteLine("++++");




// using System.Net;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;

// string token = File.ReadAllText("token.config");

// HttpClient hc = new();
// hc.BaseAddress = new Uri($"https://api.telegram.org/bot{token}/");

// int offset = 0;
// string rawData = hc.GetStringAsync($"getUpdates?offset={offset}").Result;

// JObject obj = JObject.Parse(rawData);
// JArray messages = JArray.Parse(obj["result"].ToString());

// for (int i = 0; i < messages.Count; i++)
// {
//     Console.Write($"{messages[i]["update_id"]} - ");
//     Console.Write($"{messages[i]["message"]["from"]["first_name"]} -> ");
//     Console.WriteLine($"{messages[i]["message"]["text"]}");
// }

// Console.WriteLine(obj["result"]["first_name"]);

// {
//   "ok": true,
//   "result": {
//     "id": 5913012947,
//     "is_bot": true,
//     "first_name": "AxyeHHeH",
//     "username": "boyurig_bot",
//     "can_join_groups": true,
//     "can_read_all_group_messages": false,
//     "supports_inline_queries": false
//   }
// }
















