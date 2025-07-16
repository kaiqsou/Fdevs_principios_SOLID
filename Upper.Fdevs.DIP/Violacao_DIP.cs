using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.DIP
{
    // Princípio DIP: Dependency inversion principle (princípio da inversão de dependência)
    // Esse princípio refere-se à dissociação de módulos de software. Dessa forma, em vez de módulos de alto nível, dependendo de módulos de baixo nível, ambos dependerão de abstrações.
    internal class Violacao_DIP
    {
        public class Celular
        {
            public void AbrirApp() { }
        }

        // Nesse caso, uma classe de alto nível (estudante) depende diretamente da classe Celular. Portanto, caso o estudante queira acessar as redes sociais através de outro dispositivo, não será possível.
        public class Estudante 
        {
            private Celular celular = new Celular();

            public void AcessarRedesSociais() 
            {
                // Aqui, o estudante está abrindo as redes sociais, especificamente com o dispositivo 'Celular'
                Console.WriteLine("Abrindo redes sociais pelo celular...");
                celular.AbrirApp();
            }
        }
    }
}
