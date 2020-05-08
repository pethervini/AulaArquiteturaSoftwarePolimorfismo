namespace AulaArquiteturaSoftwarePolimorfismo.Model
{
    public class Moto : Veiculo
    {

        public Moto(string nome, int ano, string cor ) 
            : base (nome, ano, cor)
        {

        }

        public override string Andar()
        {
            return "a moto está andando";
        }

        public override string Ligar()
        {
            return "A moto está ligando";
        }

        public override string Parar()
        {
            return "A moto parou";
        }
    }
}
