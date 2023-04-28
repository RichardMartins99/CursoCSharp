namespace Exercicio2DadosFuncionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) 
        { 
            SalarioBruto += porcentagem / 100 * SalarioBruto;
        }
    }
}
