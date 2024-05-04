string original = "abcde FGHIJ ABC abc DEFG     ";

string s1 = original.ToUpper();
Console.WriteLine("Original: -"+ original + "-");
Console.WriteLine("ToUpper: -"+ s1 + "-");

string s2 = original.ToLower();
Console.WriteLine("ToLower: -" + s2 + "-");

string s3 = original.Trim();
Console.WriteLine("Trim: -" + s3 + "-");

//Pega a primeira incidencia
int n1 = original.IndexOf("bc");
Console.WriteLine("IndexOf('bc'): " + n1);

//Pega a ultima incidencia
int n2 = original.LastIndexOf("bc");
Console.WriteLine("LastIndexOf('bc')" + n2);

//Recorta a string após de
string s4 = original.Substring(3);
Console.WriteLine("Substring: -" + s4 + "-");

//Recorta a string após de terminado valor e a quantidade de caracteres que deve ser recortada
string s5 = original.Substring(3, 5);
Console.WriteLine("Substring(3, 5): -" + s4 + "-");

//Troca as caracteres.Neste caso trocou todas as caracteres que tinha 'a' por 'x'
string s6 = original.Replace('a', 'x');
Console.WriteLine("Replace(a, x): -" + s6 + "-");
string s7 = original.Replace("abc", "xy");
Console.WriteLine("Replace(abc, xy): -" + s7 + "-");

bool b1 = string.IsNullOrEmpty(original);
Console.WriteLine("IsNullOrEmpty: " + b1);

bool b2 = string.IsNullOrWhiteSpace(original);
Console.WriteLine("IsNullOrWhiteSpace: " + original);