
//************************************** DATETIME
using System.Globalization;

//Pega hora e data atual do sistema
DateTime d1 = DateTime.Now;
//Data sem as horas
DateTime d2 = new DateTime(2018, 11, 25);
//Date com hora
DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
//Gera data atual com 0 horas
DateTime d4 = DateTime.Today;
//Horario universal agora
DateTime d5 = DateTime.UtcNow;

//Conversor de string para datetime
DateTime d6 = DateTime.Parse("2000-08-15");
DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d8 = DateTime.Parse("15/08/2000 13:05:58");

DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d10 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

//************************************** TimeSpan
TimeSpan t1 = new TimeSpan(0, 1, 30);
TimeSpan t2 = new TimeSpan(900000000L); //Em ticks
TimeSpan t3 = new TimeSpan(2, 11, 21);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
TimeSpan t6 = TimeSpan.FromDays(1.5);
TimeSpan t7 = TimeSpan.FromHours(1.5);
TimeSpan t8 = TimeSpan.FromMinutes(1.5);
TimeSpan t9 = TimeSpan.FromSeconds(1.5);
TimeSpan t10 = TimeSpan.FromMilliseconds(1);
TimeSpan t11 = TimeSpan.FromMicroseconds(1);
TimeSpan t12 = TimeSpan.FromTicks(900000000L);//letra "L" para indicar long