using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.DIP
{
    // Princípio DIP: Dependency inversion principle (princípio da inversão de dependência)
    // Esse princípio refere-se à dissociação de módulos de software. Dessa forma, em vez de módulos de alto nível, dependendo de módulos de baixo nível, ambos dependerão de abstrações.
    internal class Solucao_DIP
    {
        public interface IDispositivo
        {
            void AbrirApp();
        }

        public class Celular : IDispositivo
        {
            public void AbrirApp() 
            {
                Console.WriteLine("Abrindo redes sociais pelo celular...");
            }
        }

        public class Tablet : IDispositivo
        {
            public void AbrirApp()
            {
                Console.WriteLine("Abrindo redes sociais pelo tablet...");
            }
        }

        public class Estudante
        {
            private readonly IDispositivo _dispositivo;

            // atribuindo ao estudante um dispositivo, do tipo IDispositivo
            public Estudante(IDispositivo dispositivo)
            {
                _dispositivo = dispositivo;
            }

            public void AcessarRedesSociais()
            {
                // Aqui, o estudante está abrindo as redes sociais, especificamente com o dispositivo que é declarado na sua criação.
                // Dessa forma, um estudante pode acessar as redes sociais através do celular ou do tablet, de acordo com o que for lhe dado.
                _dispositivo.AbrirApp();
            }
        }
    }
}
