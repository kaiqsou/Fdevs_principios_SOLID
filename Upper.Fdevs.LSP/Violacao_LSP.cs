using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.LSP
{
    // Princípio LSP: Liskov substitution principle (princípio da substituição de Liskov)
    // Esse princípio afirma que os objetos em um programa devem ser substituíveis por instâncias de seus subtipos sem alterar a correção desse programa.
    internal class Violacao_LSP
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public string DataNascimento { get; set; }

            public void Trabalhar() {}
        }

        public class Crianca : Pessoa
        {
            public string Escola { get; set; }
            public string Professor { get; set; }

            // Inclui o método "Estudar" para a criança, mas ela também está herdando o método "Trabalhar" da classe Pessoa, que ela não pode ter. Isso viola o princípio LSP.
            public void Estudar() { }
        }
    }
}
