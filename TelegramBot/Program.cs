using System;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

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
            else
            {
                KeyboardButton[][] button = new KeyboardButton[16][];
                button[0] = new KeyboardButton[7];
                button[1] = new KeyboardButton[7];
                button[2] = new KeyboardButton[7];
                button[3] = new KeyboardButton[7];
                button[4] = new KeyboardButton[7];
                button[5] = new KeyboardButton[7];
                button[6] = new KeyboardButton[7];
                button[7] = new KeyboardButton[7];
                button[8] = new KeyboardButton[7];
                button[9] = new KeyboardButton[7];
                button[10] = new KeyboardButton[7];
                button[11] = new KeyboardButton[7];
                button[12] = new KeyboardButton[7];
                button[13] = new KeyboardButton[7];
                button[14] = new KeyboardButton[7];
                button[15] = new KeyboardButton[4];

                button[0][0] = new KeyboardButton("af 🇦🇫");
                button[0][1] = new KeyboardButton("sq 🇦🇱");
                button[0][2] = new KeyboardButton("am 🇪🇹");
                button[0][3] = new KeyboardButton("ar 🇦🇪");
                button[0][4] = new KeyboardButton("hy 🇦🇲");
                button[0][5] = new KeyboardButton("az 🇦🇿");
                button[0][6] = new KeyboardButton("eu 🏴󠁥󠁳󠁰󠁶󠁿");

                button[1][0] = new KeyboardButton("be 🇧🇾");
                button[1][1] = new KeyboardButton("bn 🇧🇩");
                button[1][2] = new KeyboardButton("bs 🇧🇦");
                button[1][3] = new KeyboardButton("bg 🇧🇬");
                button[1][4] = new KeyboardButton("ca 🏴󠁥󠁳󠁣󠁴󠁿");
                button[1][5] = new KeyboardButton("ceb 🏴󠁥󠁳󠁧󠁡󠁿");
                button[1][6] = new KeyboardButton("zh-CN 🇨🇳");

                button[2][0] = new KeyboardButton("zh-TW 🇨🇳");
                button[2][1] = new KeyboardButton("co 🏴󠁦󠁲󠁣󠁯󠁲󠁿");
                button[2][2] = new KeyboardButton("hr 🇭🇷");
                button[2][3] = new KeyboardButton("cs 🇨🇿");
                button[2][4] = new KeyboardButton("da 🇩🇰");
                button[2][5] = new KeyboardButton("nl 🇳🇱");
                button[2][6] = new KeyboardButton("en 🇬🇧");

                button[3][0] = new KeyboardButton("eo 🏴󠁥󠁳󠁧󠁡󠁿");
                button[3][1] = new KeyboardButton("et 🇪🇪");
                button[3][2] = new KeyboardButton("fi 🇫🇮");
                button[3][3] = new KeyboardButton("fr 🇫🇷");
                button[3][4] = new KeyboardButton("fy 🏴󠁮󠁬󠁦󠁲󠁿");
                button[3][5] = new KeyboardButton("gl 🏴󠁥󠁳󠁧󠁡󠁿");
                button[3][6] = new KeyboardButton("ka 🇬🇪");

                button[4][0] = new KeyboardButton("de 🇩🇪");
                button[4][1] = new KeyboardButton("el 🇬🇷");
                button[4][2] = new KeyboardButton("gu 🏴󠁩󠁮󠁧󠁪󠁿");
                button[4][3] = new KeyboardButton("ht 🇭🇹");
                button[4][4] = new KeyboardButton("ha 🏴󠁥󠁳󠁧󠁡󠁿");
                button[4][5] = new KeyboardButton("haw 🏴󠁵󠁳󠁨󠁩󠁿");
                button[4][6] = new KeyboardButton("he(iw) 🏴󠁥󠁳󠁧󠁡󠁿");

                button[5][0] = new KeyboardButton("hi 🇮🇳");
                button[5][1] = new KeyboardButton("hmn 🏴󠁥󠁳󠁧󠁡󠁿");
                button[5][2] = new KeyboardButton("hu 🇭🇺");
                button[5][3] = new KeyboardButton("is 🇮🇸");
                button[5][4] = new KeyboardButton("ig 🇳🇬");
                button[5][5] = new KeyboardButton("id 🇮🇩");
                button[5][6] = new KeyboardButton("ga 🇮🇪");

                button[6][0] = new KeyboardButton("it 🇮🇹");
                button[6][1] = new KeyboardButton("ja 🇯🇵");
                button[6][2] = new KeyboardButton("jv 🇮🇩");
                button[6][3] = new KeyboardButton("kn 🇮🇳");
                button[6][4] = new KeyboardButton("kk 🇰🇿");
                button[6][5] = new KeyboardButton("km 🇰🇭");
                button[6][6] = new KeyboardButton("rw 🇷🇼");

                button[7][0] = new KeyboardButton("ko 🇰🇷");
                button[7][1] = new KeyboardButton("ku 🇮🇷");
                button[7][2] = new KeyboardButton("ky 🇰🇬");
                button[7][3] = new KeyboardButton("lo 🇱🇦");
                button[7][4] = new KeyboardButton("la 🇦🇷");
                button[7][5] = new KeyboardButton("lv 🇱🇻");
                button[7][6] = new KeyboardButton("lt 🇱🇹");

                button[8][0] = new KeyboardButton("lb 🇩🇪");
                button[8][1] = new KeyboardButton("mk 🇲🇰");
                button[8][2] = new KeyboardButton("mg 🇲🇬");
                button[8][3] = new KeyboardButton("ms 🇧🇳");
                button[8][4] = new KeyboardButton("ml 🇮🇳");
                button[8][5] = new KeyboardButton("mt 🇲🇹");
                button[8][6] = new KeyboardButton("mi 🇳🇿");

                button[9][0] = new KeyboardButton("mr 🇮🇳");
                button[9][1] = new KeyboardButton("mn 🇲🇳");
                button[9][2] = new KeyboardButton("my 🇲🇲");
                button[9][3] = new KeyboardButton("ne 🇳🇵");
                button[9][4] = new KeyboardButton("no 🇳🇴");
                button[9][5] = new KeyboardButton("ny 🇲🇼");
                button[9][6] = new KeyboardButton("or 🇮🇳");

                button[10][0] = new KeyboardButton("ps 🇮🇷");
                button[10][1] = new KeyboardButton("fa 🇮🇷");
                button[10][2] = new KeyboardButton("pl 🇵🇱");
                button[10][3] = new KeyboardButton("pt 🇵🇹");
                button[10][4] = new KeyboardButton("pa 🇮🇳");
                button[10][5] = new KeyboardButton("ro 🇷🇴");
                button[10][6] = new KeyboardButton("ru 🇷🇺");

                button[11][0] = new KeyboardButton("sm 🇼🇸");
                button[11][1] = new KeyboardButton("gd 🏴󠁥󠁳󠁣󠁴󠁿");
                button[11][2] = new KeyboardButton("sr 🇷🇸");
                button[11][3] = new KeyboardButton("st 🏴󠁥󠁳󠁣󠁴󠁿");
                button[11][4] = new KeyboardButton("sn 🇿🇼");
                button[11][5] = new KeyboardButton("sd 🏴󠁥󠁳󠁣󠁴󠁿");
                button[11][6] = new KeyboardButton("si 🇱🇰");

                button[12][0] = new KeyboardButton("sk 🇸🇰");
                button[12][1] = new KeyboardButton("sl 🇸🇮");
                button[12][2] = new KeyboardButton("so 🇸🇴");
                button[12][3] = new KeyboardButton("es 🇪🇸");
                button[12][4] = new KeyboardButton("su 🇮🇩");
                button[12][5] = new KeyboardButton("sw 🇨🇩");
                button[12][6] = new KeyboardButton("sv 🇸🇪");

                button[13][0] = new KeyboardButton("tl 🇵🇭");
                button[13][1] = new KeyboardButton("tg 🇹🇯");
                button[13][2] = new KeyboardButton("ta 🇮🇳");
                button[13][3] = new KeyboardButton("tt 🇹🇷");
                button[13][4] = new KeyboardButton("te 🇮🇳");
                button[13][5] = new KeyboardButton("th 🇹🇭");
                button[13][6] = new KeyboardButton("tr 🇹🇷");

                button[14][0] = new KeyboardButton("tk 🇹🇲");
                button[14][1] = new KeyboardButton("uk 🇺🇦");
                button[14][2] = new KeyboardButton("ur 🇵🇰");
                button[14][3] = new KeyboardButton("ug 🇹🇷");
                button[14][4] = new KeyboardButton("uz 🇺🇿");
                button[14][5] = new KeyboardButton("vi 🇻🇳");
                button[14][6] = new KeyboardButton("cy 🇬🇧");

                button[15][0] = new KeyboardButton("xh 🇿🇼");
                button[15][1] = new KeyboardButton("yi 🇷🇺");
                button[15][2] = new KeyboardButton("yo 🇳🇬");
                button[15][3] = new KeyboardButton("zu 🏴󠁺󠁡󠁮󠁬󠁿");

                ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(button);
                bot.SendTextMessageAsync(e.Message.Chat, "Selecte the language!" + "\n ይምረጡ!", replyMarkup: keyboardMarkup);
            }
        }
    }
}
