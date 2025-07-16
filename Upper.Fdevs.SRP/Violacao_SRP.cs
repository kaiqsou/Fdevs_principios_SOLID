using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.SRP
{
    // Príncipio SRP: Single-responsibility principle (princípio de responsabilidade única)
    // Cada módulo ou classe deve ser responsável por uma única parte do software
    internal class Violacao_SRP
    {
        public class Medico
        {
            public string nome { get; set; }
            public string cpf { set; get; }

            // Aqui, está sendo atribuída ao médico muitas funções diferentes
            public void Operar(){}
            public void Anestesiar(){}
            public void EmitirRelatoriosFinanceiros(){}
            public void AtualizarSistema(){}

        }
    }
}
