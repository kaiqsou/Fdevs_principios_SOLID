using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.SRP
{
    // Príncipio SRP: Single-responsibility principle (princípio de responsabilidade única)
    // Cada módulo ou classe deve ser responsável por uma única parte do software
    internal class Solucao_SRP
    {
        // Aqui, o médico terá funções apenas referentes ao seu ramo. É possível deixar ainda mais dividido, ao criar, por exemplo, uma classe de "anestesistas"
        public class Medico
        {
            public string nome { get; set; }
            public string cpf { set; get; }
            public void Operar() { }
            public void Anestesiar() { }
        }

        public class Financeiro
        {
            public string nome { get; set; }
            public string cpf { set; get; }
            public void EmitirRelatoriosFinanceiros() { }
        }

        public class Programador
        {
            public string nome { get; set; }
            public string cpf { set; get; }
            public void AtualizarSistema() { }
        }
    }
}
