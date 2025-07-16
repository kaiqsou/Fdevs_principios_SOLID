using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Fdevs.OCP
{
    // Príncipio OCP: Open-closed principle (princípio aberto-fechado)
    // Esse princípio diz que as classes devem estar abertas para extensão, mas fechadas para modificação.
    internal class Solucao_OCP
    {
            // Interface para Herança
            public interface IClassificador
            {
                string ClassificarNumero(double numero);
            }

            // Abaixo estão as classes de classificações, que herdam da Interface.
            // Nessa solução, se for necessário adicionar novas classificações posteriormente, não será necessário modificar diretamente a classe principal.

            public class ParImpar : IClassificador
            {
                // Classifica como "Número Par" ou "Número Ímpar"
                public string ClassificarNumero(double numero)
                {
                    if (numero % 2 == 0)
                    {
                        return "Número Par";
                    }
                    else
                    {
                        return "Número Ímpar";
                    }
                }
            }

            public class PositivoNegativo : IClassificador
            {
                 // Classifica como "Número Positivo" ou "Número Negativo"
                public string ClassificarNumero(double numero)
                {
                    if (numero >= 0)
                    {
                        return "Número Positivo";
                    }
                    else
                    {
                        return "Número Negativo";
                    }
                }
            }
    }
}
