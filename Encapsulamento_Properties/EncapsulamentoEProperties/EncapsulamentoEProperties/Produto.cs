namespace EncapsulamentoEProperties
{
    public class Produto
    {
        private string _nome;
        //AutoProperties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(
            string nome,
            double preco,
            int quantidade) 
        {  
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Properties
        public string Nome 
        { 
            get { return _nome; }
            set 
            { 
                if (value != null && value.Length > 1)
                {
                    _nome += value;
                }
            }
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
