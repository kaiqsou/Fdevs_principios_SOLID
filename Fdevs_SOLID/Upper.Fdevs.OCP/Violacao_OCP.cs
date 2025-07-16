using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.OCP
{
    // Príncipio OCP: Open-closed principle (princípio aberto-fechado)
    // Esse princípio diz que as classes devem estar abertas para extensão, mas fechadas para modificação.
    internal class Violacao_OCP
    {
        public class Classificador
        {
            // Nesse caso, o método apenas classifica números pares ou ímpares. Caso seja desejado posteriormente adicionar uma nova classificação, teria que mexer nessa classe principal.
            public string ClassificarNumero(double numero)
            {
                if (numero % 2 == 0)
                {
                    return "Número par";
                }
                else
                {
                    return "Número ímpar";
                }
            }
        }
    }
}
