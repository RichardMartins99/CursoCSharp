
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

//*************************************** Propriedades DateTime
DateTime dt = new DateTime(2001, 8, 15, 13, 45, 58, 275);

Console.WriteLine(dt);
Console.WriteLine("1) Date: " + dt.Date);// Desconsidera o horario
Console.WriteLine("2) Day: " + dt.Day); //Pega o dia da data
Console.WriteLine("3) DayOfWeek: " + dt.DayOfWeek);
Console.WriteLine("4) DayOfYear: " + dt.DayOfYear); 
Console.WriteLine("5) Hour: " + dt.Hour); 
Console.WriteLine("6) Kind: " + dt.Kind); 
Console.WriteLine("7) Millisecond: " + dt.Millisecond); 
Console.WriteLine("8) Minute: " + dt.Minute); 
Console.WriteLine("9) Month: " + dt.Month); 
Console.WriteLine("10) Second: " + dt.Second); 
Console.WriteLine("11) Ticks: " + dt.Ticks); 
Console.WriteLine("12) TimeOfDay: " + dt.TimeOfDay); 
Console.WriteLine("13) Year: " + dt.Year);

Console.WriteLine(dt.ToLongDateString());
Console.WriteLine(dt.ToLongTimeString());
Console.WriteLine(dt.ToShortDateString());
Console.WriteLine(dt.ToShortTimeString());
Console.WriteLine(dt.ToString("dd/MM/yyyy HH:mm:ss.fff"));

//*************************************** Operações com DateTime
DateTime dt2 = dt.AddHours(2);
DateTime dt3 = dt.AddMinutes(3);
DateTime dt4 = dt.AddDays(4);
TimeSpan dt5 = d4.Subtract(d2);

//***************************************** Propriedades com TimeSpan
TimeSpan ts = new TimeSpan(2, 3, 5, 7, 11);
TimeSpan ts1 = TimeSpan.MaxValue;
TimeSpan ts2 = TimeSpan.MinValue;
TimeSpan ts3 = TimeSpan.Zero;
//Numeros Inteiros
Console.WriteLine("Days: " + ts.Days);
Console.WriteLine("Hours: " + ts.Hours);
Console.WriteLine("MInutes: " + ts.Minutes);
Console.WriteLine("Milliseconds: " + ts.Milliseconds);
Console.WriteLine("Seconds: " + ts.Seconds);
Console.WriteLine("Ticks: " + ts.Ticks);
//Numeros double
Console.WriteLine("TotalDays: " + ts.TotalDays);
Console.WriteLine("TotalHours: " + ts.TotalHours);
Console.WriteLine("TotalMinutes: " + ts.TotalMinutes);
Console.WriteLine("TotalSeconds: " + ts.TotalSeconds);
Console.WriteLine("TotalMilliseconds: " + ts.TotalMilliseconds);

//***************************************** Operações com TimeSpan
TimeSpan tsp = new TimeSpan(1, 30, 10);
TimeSpan tsp2 = new TimeSpan(0, 10, 5);
TimeSpan soma = tsp.Add(tsp2);
TimeSpan dif = tsp.Subtract(tsp2);
TimeSpan mult = tsp2.Multiply(2.0);
TimeSpan div = tsp2.Divide(2.0);

Console.WriteLine(soma);
Console.WriteLine(dif);
Console.WriteLine(mult);
Console.WriteLine(div);

//**************** Boas praticas com DateTime
// DateTime Kind e Padrão ISO8601

DateTime dtm = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime dtm1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime dtm2 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine("Date" + dtm);
Console.WriteLine("Date Local" + dtm.Kind);
Console.WriteLine("Date Kind" + dtm.ToLocalTime());
Console.WriteLine("Date ToUtc" + dtm.ToUniversalTime());

DateTime dtm3 = DateTime.Parse("2000-08-15T13:05:58Z");
Console.WriteLine();

//Padrão ISO8601 2000-08-15T13:05:58Z
