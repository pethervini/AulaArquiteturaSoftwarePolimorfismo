namespace AulaArquiteturaSoftwarePolimorfismo
{
    public abstract class Veiculo
    {
        private readonly string _nome;
        private readonly int _ano;
        private readonly string _cor;

        protected Veiculo(string nome, int ano, string cor)
        {
            _nome = nome;
            _ano = ano;
            _cor = cor;
        }        

        public abstract string Ligar();
        public abstract string Andar();
        public abstract string Parar();
    }
}