namespace ex3
{
    public class Moradores
    {
        private string telefone;

        private int numResidencia;

        private string cachorro;

        //Get Set do Telefone
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        //Get Set da residencia
        public int NumResidencia
        {
            get { return numResidencia; }
            set { numResidencia = value; }
        }

        //Get Set da existencia de cachorro
        public string Cachorro
        {
            get { return cachorro; }
            set { cachorro = value; }
        }

    }
}