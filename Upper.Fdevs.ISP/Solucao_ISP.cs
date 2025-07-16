using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.ISP
{
    // Princípio ISP: Interface segregation principle (princípio da segregação de interface)
    // Esse princípio afirma que nenhum cliente deve ser forçado a depender dos métodos que não usa, e para isso, interfaces maiores são 'quebradas' em interfaces menores.
    internal class Solucao_ISP
    {
        // Interface para profissionais de educação
        public interface IProfissionalEducacao
        {
            void DarAulas();
        }

        // Interface para profissionais de carros
        public interface IProfissionalCarros
        {
            void ConsertarCarros();
        }

        // Interface para profissionais de cozinha
        public interface IProfissionalCozinha
        {
            void Cozinhar();
        }

        // Classes - dessa forma, cada função de profissional recebe os seus devidos métodos, de forma bem organizada e sem métodos desnecessários.
        public class Professor : IProfissionalEducacao
        {
            public void DarAulas() { }
        }

        public class Mecanico : IProfissionalCarros
        {
            public void ConsertarCarros() { }
        }

        public class Cozinheiro : IProfissionalCozinha
        {
            public void Cozinhar() { }
        }


    }
}
