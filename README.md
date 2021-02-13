# TelegramBot
This bot is transelate any languge to differnt languge.
First you have to ensert the word or sentence to the text box by typing and then selecte the languge when the custom keybord are came.
And also the name of the bot is  Translator(@AmanTranslatorBot).
"the Quary"

create database DB

go

create table tbTelegram

(ID int unique,

Quations nvarchar(MAX),

Answere nvarchar(MAX),

Point int

);

go

insert into tbTelegram(ID,Quations,Answere,Point)

values (1,N'ከአንድ ብርቱ ____',N'ሁለት መዳኒቱ',10)

insert into tbTelegram(ID,Quations,Answere,Point)

values (2,N'____ ጫጩት ያርዳል',N'ሰው ለወዳጁ',10)

insert into tbTelegram(ID,Quations,Answere,Point)

values (3,N'ላም አለኝ ____ ወተትዋን የማላይ',N'በሰማይ',10)

insert into tbTelegram(ID,Quations,Answere,Point)

values (4,N'ሁለት እግር አለኝ ተብሎ ____ ላይ አይወጣም',N'ሁለት ዛፍ',10)

go

create proc spView

as 

select REPLACE(Quations,'____',Answere) as Sentence

from tbTelegram

go

create table tbTelegramA

(ID int unique,

Quations nvarchar(MAX),

Answere nvarchar(MAX),

Point int

);

go

create proc spViewA

as 

select REPLACE(Quations,'____',Answere) as Sentence

from tbTelegramA

go

insert into tbTelegramA(ID,Quations,Answere,Point)

values (1,N'ስምህን ____ ይጥራው',N'ቄስ',10)

insert into tbTelegramA(ID,Quations,Answere,Point)

values (2,N'ስንዝር ሲሰጡት ____',N'ጋት',10)

insert into tbTelegramA(ID,Quations,Answere,Point)

values (3,N'____ ፀጉር ተነቀለ',N'ከምላስ',10)

insert into tbTelegramA(ID,Quations,Answere,Point)

values (4,N'የአፍ ____ በገበያም አይገድ',N'ዘመድ',10)

go

create proc spQuation

as

declare @x int

set @x=ROUND(RAND()*1,0)+1

if(@x = 1)

select ID,Quations,Answere

from tbTelegram

where ID=ROUND( RAND() * (select count(*)-1 from tbTelegram), 0 ) + 1

else

select ID,Quations,Answere

from tbTelegramA

where ID=ROUND( RAND() * (select count(*)-1 from tbTelegramA), 0 ) + 1

go
