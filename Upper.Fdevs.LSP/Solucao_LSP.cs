using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.LSP
{
    // Princípio LSP: Liskov substitution principle (princípio da substituição de Liskov)
    // Esse princípio afirma que os objetos em um programa devem ser substituíveis por instâncias de seus subtipos sem alterar a correção desse programa.
    internal class Solucao_LSP
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public string DataNascimento { get; set; }
        }

        // Dessa forma, as instâncias da classe Pessoa estão cumprindo deveres diferentes, sem métodos indevidos.
        public class Crianca : Pessoa
        {
            public string Escola { get; set; }
            public string Professor { get; set; }

            public void Estudar() { } // Criança pode estudar
        }

        public class Adulto : Pessoa
        {
            public string Empresa { get; set; }
            public string Cargo { get; set; }

            public void Trabalhar() { } // Adulto pode trabalhar
        }
    }
}
