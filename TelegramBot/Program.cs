using System;
using Telegram.Bot;

namespace TelegramBot
{
    class Program
    {
        private static readonly TelegramBotClient bot = new TelegramBotClient("1428816140:AAHZGqsBzRkQ_MEapfWgbReIUyjxuavedLo");
        static void Main(string[] args)
        {
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();
            Console.ReadLine();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Text == "/start")
                bot.SendTextMessageAsync(e.Message.Chat.Id, "Enter your word or sentence that is going to translate!" +
                                                                       "\nእንዲቀየርሎት የሚፈልጉትን ቃል ወይም ዐረፍተ-ነገር ያስገቡ! ");
        }
    }
}
