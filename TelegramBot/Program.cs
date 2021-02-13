using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Data;
using System.Data.SqlClient;

namespace TelegramBot
{
    class Program
    {
        static int markupID, errMsgID;
        static string id;
        static int point;

        private static readonly TelegramBotClient bot = new TelegramBotClient("1428816140:AAHZGqsBzRkQ_MEapfWgbReIUyjxuavedLo");

        static string url = "Data Source=LAPTOP-2NIMB6UI\\SQLEXPRESS01;Initial Catalog=DB;Integrated Security=True";
        
        static void Main(string[] args)
        {
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();
            Console.ReadLine();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {     
            if (e.Message.Text == "/start")
            {
                    deleteErrorMsg(e);
                    First(e);  
            }
            else
            {
                if (e.Message.Text == "ምስሊያዊ አነጋገር")
                {
                    bot.DeleteMessageAsync(e.Message.Chat.Id, e.Message.MessageId);
                    bot.DeleteMessageAsync(e.Message.Chat.Id, markupID);
                    KeyboardButton[][] button = new KeyboardButton[2][];
                    button[0] = new KeyboardButton[2];
                    button[1] = new KeyboardButton[1];
               
                    button[0][0] = new KeyboardButton("ምስሊያዊ አነጋገር");
                    button[0][1] = new KeyboardButton("ፈሊጣዊ አነጋገር");

                    button[1][0] = new KeyboardButton("ጥያቄ");

                    ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(button);
                    Message data = bot.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text: dataምስሊያዊ(),
                    parseMode: ParseMode.Html,
                     replyMarkup: keyboardMarkup
                    ).Result;
                    markupID = data.MessageId;
                }
                else if(e.Message.Text== "ፈሊጣዊ አነጋገር")
                {
                    bot.DeleteMessageAsync(e.Message.Chat.Id, e.Message.MessageId);
                    bot.DeleteMessageAsync(e.Message.Chat.Id, markupID);
                    KeyboardButton[][] button = new KeyboardButton[2][];
                    button[0] = new KeyboardButton[2];
                    button[1] = new KeyboardButton[1];
                
                    button[0][0] = new KeyboardButton("ምስሊያዊ አነጋገር");
                    button[0][1] = new KeyboardButton("ፈሊጣዊ አነጋገር");

                    button[1][0] = new KeyboardButton("ጥያቄ");

                    ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(button);
                    Message data = bot.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text: dataፈሊጣዊ(),
                    parseMode: ParseMode.Html,
                    replyMarkup: keyboardMarkup
                    ).Result;
                    markupID = data.MessageId;
                }
                else if (e.Message.Text == "ጥያቄ")
                {
                    string d1="";
                    string d2="";
                    string d3="";
                    string d4="";
                    if (!String.Equals(d1, d2) && !String.Equals(d2, d3) && !string.Equals(d1, d3))
                    {
                        d1 += dataመልስ();
                        d2 += dataመልስ();
                        d3 += dataመልስ();
                        d4 += dataመልስ();
                    }
                    if (e.Message.Text == dataመልስ())
                    {
                        point += 10;
                        bot.DeleteMessageAsync(e.Message.Chat.Id, e.Message.MessageId);
                        bot.DeleteMessageAsync(e.Message.Chat.Id, markupID);
                       
                        
                        
                            KeyboardButton[][] button = new KeyboardButton[2][];
                            button[0] = new KeyboardButton[2];
                            button[1] = new KeyboardButton[2];

                            button[0][0] = new KeyboardButton(d1);
                            button[0][1] = new KeyboardButton(d2);

                            button[1][0] = new KeyboardButton(d3);
                            button[1][1] = new KeyboardButton(d4);
                            ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(button);
                            Message data = bot.SendTextMessageAsync(
                            chatId: e.Message.Chat,
                            text: dataጥያቄ(),
                            parseMode: ParseMode.Html,
                             replyMarkup: keyboardMarkup
                            ).Result;
                            markupID = data.MessageId;
                        
                        

                    }
                    else
                    {

                        bot.DeleteMessageAsync(e.Message.Chat.Id, e.Message.MessageId);
                        bot.DeleteMessageAsync(e.Message.Chat.Id, markupID);
                        
                        KeyboardButton[][] button = new KeyboardButton[2][];
                        button[0] = new KeyboardButton[2];
                        button[1] = new KeyboardButton[2];

                        button[0][0] = new KeyboardButton(d1);
                        button[0][1] = new KeyboardButton(d2);

                        button[1][0] = new KeyboardButton(d3);
                        button[1][1] = new KeyboardButton(d4);
                        ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(button);
                        Message data = bot.SendTextMessageAsync(
                        chatId: e.Message.Chat,
                        text: dataጥያቄ(),
                        parseMode: ParseMode.Html,
                         replyMarkup: keyboardMarkup
                        ).Result;
                        markupID = data.MessageId;
                    }
                }
            }
        }

        static string dataምስሊያዊ()
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                string msg = ""; 
                SqlCommand cmd = new SqlCommand("spView", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                reader.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    msg += row["Sentence"].ToString() + "\n";
                }

                con.Close();
                return msg;
             
            }

        }
        static string dataፈሊጣዊ()
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                string msg = "";
                SqlCommand cmd = new SqlCommand("spViewA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                reader.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    msg += row["Sentence"].ToString() + "\n";
                }

                con.Close();
                return msg;
            }
        }

        static string dataጥያቄ()
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                string msg = "";
               
                SqlCommand cmd = new SqlCommand("spQuation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                reader.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    msg += row["Quations"].ToString(); ;

                }

                con.Close();
                return msg;
            }
        }

        static string dataመልስ()
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                string msg = "";
                msg = id;
                SqlCommand cmd = new SqlCommand("spQuation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                reader.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {

                    msg += row["Answere"].ToString() ;
                }

                con.Close();
                return msg;
            }
            
        }
        static void First(Telegram.Bot.Args.MessageEventArgs e)
        {
            KeyboardButton[][] button = new KeyboardButton[2][];
            button[0] = new KeyboardButton[2];
            button[1] = new KeyboardButton[1];
            
            button[0][0] = new KeyboardButton("ምስሊያዊ አነጋገር");
            button[0][1] = new KeyboardButton("ፈሊጣዊ አነጋገር");

            button[1][0] = new KeyboardButton("ጥያቄ");

            ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(button);
            bot.DeleteMessageAsync(e.Message.Chat.Id, e.Message.MessageId);
            Message Keyboard_msg = bot.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text: "Selecte your choice! የሚፈልጉትን ይምረጡ!",
                    parseMode: ParseMode.Html,
                    disableNotification: true,
                    replyMarkup: keyboardMarkup
                    ).Result;
            markupID = Keyboard_msg.MessageId;
        }

        static void deleteErrorMsg(Telegram.Bot.Args.MessageEventArgs e)
        {
            //catches message not found exception
            try
            {
                bot.DeleteMessageAsync(e.Message.Chat.Id, errMsgID);
            }
            catch (Exception)
            {

            }
        }
    }
}
