using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SistemaVagas
    {
        string[] curricolo = new string[100];
        string[] nomeVaga = new string[100];
        int[] periodo = new int[100];
        string[] cargo = new string[100];
        double[] horario = new double[100];
        string[] benaficio = new string[100];
        int atual = 0;
        public void cadastrarVaga()
        {
            Console.Write("icira seu curricolo: ");
            curricolo[atual] = Console.ReadLine().ToLower();
            Console.Write("digite nome da vaga: ");
            nomeVaga[atual] = Console.ReadLine().ToLower();
            Console.Write("digite o periodo: ");
            periodo[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite cargo: ");
            cargo[atual] = Console.ReadLine();
            Console.Write("digite horario: ");
            horario[atual] = Convert.ToDouble(Console.ReadLine());
            Console.Write("dijite os beneficios: ");
            benaficio[atual] = Console.ReadLine();
            atual++;

        }
        public void editarVaga()
        {
            Console.Clear();
            Console.Write("Digite uma vaga para ser pesquisada: ");
            string pesquisaV = Console.ReadLine().ToLower().Trim();
            int pocicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (pesquisaV == curricolo[i])
                {
                    pocicao = -1;
                }
            }
            if (pocicao != -1)
            {
                Console.WriteLine("Curricolo: " + curricolo[atual] +
                    "\nVaga: " + nomeVaga[atual] +
                    "\nPeriodo: " + periodo[atual] +
                    "\nCargo: " + cargo[atual] +
                    "\nhorario: " + horario[atual] +
                    "\nBeneficios: " + benaficio[atual]);
                Console.WriteLine("");
                Console.Write("incira seu curricolo: ");
                curricolo[atual] = Console.ReadLine();
                Console.Write("Digite nome da vaga: ");
                nomeVaga[atual] = Console.ReadLine();
                Console.Write("digite o periodo: ");
                periodo[atual] = Convert.ToInt32(Console.ReadLine());
                Console.Write("digite o cargo: ");
                cargo[atual] = Console.ReadLine();
                Console.Write("dijite o Horario: ");
                horario[atual] = Convert.ToDouble(Console.ReadLine());
                Console.Write("digite os benaficios: ");
                benaficio[atual] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nome nao encontrado!!");
            }
            Console.ReadKey();

        }
        public void buscarVagas()
        {
            Console.Clear();
            Console.Write("digite um nome para busca de vaga: ");
            string Buscavaga = Console.ReadLine().ToLower();
            bool encontrou = true;
            for (int i = 0; i < atual; i++)
            {
                if (Buscavaga == nomeVaga[atual])
                {
                    Console.WriteLine(string.Format("\nCurricolo:{0}\nNome:{0}\nperiodo:{0}\nPeiodo:{0}\nCargo:{0}\nHorario:{0}\nBeneficios:{0}",
                        curricolo[i], nomeVaga[i], periodo[i], cargo[i], horario[i], benaficio[i]));
                    break;
                }
                if (!encontrou)
                {
                    Console.WriteLine("nome nao encontrado!");
                }
            }
        }
        public void listatVagas()
        {
            Console.Clear();
            Console.Write("Lista de vagas: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(string.Format("\nCurricolo:{0}\nNome:{0}\nperiodo:{0}\nPeiodo:{0}\nCargo:{0}\nHorario:{0}\nBeneficios:{0}",
                   curricolo[i], nomeVaga[i], periodo[i], cargo[i], horario[i], benaficio[i]));
            }

        }


    }


}

    

