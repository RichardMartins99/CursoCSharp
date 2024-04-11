using ModificadorDeParametrosParams;
//Params

//Utilizando o params
var returnSoma = Calculadora.Soma(2, 4, 5, 6);
Console.WriteLine(returnSoma);

//Sem params
var soma = Calculadora.Soma(new int[] { 2, 3, 7 });
Console.WriteLine(soma);

//Ref e Out são considerados designs ruins e devem ser evitados.
//------------------------------------------------------------------

//Ref exige que a variavel seja iniciada.
var a = 10;
Calculadora.Triple(ref a);
Console.WriteLine(a);

//------------------------------------------------------------------

//Out armazena o valor na variavel de saida
int b = 10;
int triple;
Calculadora.TripleOut(b, out triple);
Console.WriteLine(triple);