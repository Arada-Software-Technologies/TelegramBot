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
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
