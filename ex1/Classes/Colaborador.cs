namespace ex1.Classes
{
    public class Colaborador
    {
        public string Nome { get; set; }

        public int Matricula { get; set; }

        public Colaborador(string nome, int mat)
        {
            this.Nome = nome;
            this.Matricula = mat;
        }
    }
}