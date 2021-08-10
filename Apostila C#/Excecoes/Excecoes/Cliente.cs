namespace Excecoes
{
    public class Cliente
    {
        private string cpf;

        public string Nome { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
    }
}