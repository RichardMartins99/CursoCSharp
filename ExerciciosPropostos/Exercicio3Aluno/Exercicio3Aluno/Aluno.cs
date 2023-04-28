namespace Exercicio3Aluno
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double SomadorDeNotas()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string ResultadoNotas()
        {
            var notaFinal = Nota1 + Nota2 + Nota3;
            return notaFinal > 60.00 ? "APROVADO" : $"REPROVADO FALTAM {60 - notaFinal} PONTOS ";
        }
    }
}
