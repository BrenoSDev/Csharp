using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoEModificadoresDeAcesso
{
    //Quando declaramos uma classe no C#, por padrão ela só pode ser vista dentro do próprio projeto, esse é um nível
    //de visibilidade conhecido como internal. Quando queremos trabalhar com bibliotecas externas ao projeto, nossas
    //classes precisam ser declaradas com a visibilidade public

    //internal é a visibilidade padrão para a classe, portanto a palavra internal é opcional
    public class AtualizadorDeContas
    {
        public void Atualiza(Conta conta)
        {

        }
    }
}
