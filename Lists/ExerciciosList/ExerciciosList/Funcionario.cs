namespace ExerciciosList
{
    public class Funcionario
    {
        public Funcionario(
            int id,
            string nome,
            double salario) 
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public void AumentarSalario(double aumento)
        {
            var valor = Salario * (aumento / 100);
            Salario = Salario + valor;
        }
    }
}
