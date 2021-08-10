namespace Banco
{
    public class Cliente
    {
        private string cpf;

        public string Nome { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        //Renomear uma variável existente é uma tarefa árdua, pois não adianta apenas renomearmos a declaração da
        //variável, precisamos também mudar todos os lugares que a utilizam. Quando queremos fazer uma renomeação
        //de variáveis, podemos utilizar o atalho (Ctrl + R duas vezes)
        //O mesmo atalho pode ser usado para renomearmos classes, métodos, atributos e propriedades de código

        public bool PodeAbrirContaSozinho
        {
            get
            {
                //Variáveis dentro de métodos podem ser declaradas como var em C# que o seu tipo é inferido automaticamente
                //Para o compilador acertar qual o tipo da variável ela deve ser inicializada no mesmo instante que é 
                //declarada e não pode ser atribuído o valor null
                var maiorDeIdade = this.Idade >= 18;
                
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (maiorDeIdade) && possuiCPF;

                //Uma variável declarada como var possui um tipo bem definido e não pode ser alterado
            }
        }

        public int Idade { get; set; }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = (Cliente)obj;
            return this.Nome == outroCliente.Nome;
        }
    }
}