using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.ISP
{
    // Princípio ISP: Interface segregation principle (princípio da segregação de interface)
    // Esse princípio afirma que nenhum cliente deve ser forçado a depender dos métodos que não usa, e para isso, interfaces maiores são 'quebradas' em interfaces menores.
    internal class Violacao_ISP
    {
        public interface IProfissional
        {
            void DarAulas();
            void ConsertarCarros();
            void Cozinhar();
        }

        public class Professor : IProfissional
        {
            // a classe professor utilizaria apenas o método DarAulas, mas por herdar de Profissional, desnecessariamente terá que declarar "ConsertarCarros" e "Cozinhar", algo que viola o princípio ISP.
            public void DarAulas() { }
            public void ConsertarCarros() { }
            public void Cozinhar() { }
        }
    }
}
