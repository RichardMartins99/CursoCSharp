internal static class CalculadoraHelpers
{
    public static int Calculadora(params int[] numeros)
    {
        int soma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }

        return soma;
    }
}