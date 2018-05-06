using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SistemaCliente
    {
        string[] cliente = new string[100];
        double[] cpf = new double[100];
        string[] endereco = new string[100];
        int[] fone = new int[100];
        int[] idade = new int[100];
        double[] peso = new double[100];
        int atual = 0;
        public void CadastroCliente()
        {

            Console.Write("Digite seu nome: ");
            cliente[atual] = Console.ReadLine().ToLower();
            Console.Write("Dijite seu CPF: ");
            cpf[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dijite seu endereso: ");
            endereco[atual] = Console.ReadLine();
            Console.Write("Dijite sue telefone:");
            fone[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite sua idade: ");
            idade[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite seu peso: ");
            peso[atual] = Convert.ToDouble(Console.ReadLine());
            atual++;

        }
        public void Editarcliente()
        {
            Console.Clear();
            Console.Write("digite o nume para pesquisar: ");
            string pesquisa = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (pesquisa == cliente[i])
                {
                    posicao = i;
                }
            }
            if (posicao != -1)
            {
                Console.WriteLine(" Nome: "+cliente[atual]+
                    "\n CPF: "+cpf[atual]+
                    "\n endereco:"+endereco[atual]+
                    "\n telefone: "+fone[atual]+
                    "\n idade: "+idade[atual]+
                    "\n peso: "+peso[atual]);
                Console.WriteLine("");
                // Coloque informaçoes

                Console.Write("digite nome: ");
                cliente[posicao] = Console.ReadLine();
                Console.Write("Dijite seu CPF: ");
                cpf[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dijite seu endereso: ");
                endereco[posicao] = Console.ReadLine();
                Console.Write("Dijite sue telefone:");
                fone[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("digite sua idade: ");
                idade[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("digite seu peso: ");
                peso[posicao] = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.Write("nome nao emcontrado!");

            }
            Console.ReadKey();
        }
        public void Buscarcliente()
        { Console.Clear();
            Console.Write("digite um nome para busca: ");
            string Buscanome = Console.ReadLine().ToLower();
            bool encontrou = true;
            for (int i = 0; i < atual; i++)
            {
                if (Buscanome == cliente[i])
                {
                    Console.Write(string.Format("\nNome:{0}\ncpf:{0}\nendereso:{0}\ntelefole:{0}\nidade:{0}\npeso:{0}",
                        cliente[i],cpf[i],endereco[i],fone[i],idade[i],peso[i]));
                    break;
                }
            }
            if (! encontrou)
            {
                Console.WriteLine("nome nao encontrado!!");
            }
        }
        public void ListarCliente()
        {
            Console.Clear();
            Console.Write("lista de clientes: ");
            for(int i = 0; i < atual; i++)
            {

                Console.Write(string.Format("\nNome:{0}\ncpf:{0}\nendereso:{0}\ntelefole:{0}\nidade:{0}\npeso:{0}",
                    cliente[i], cpf[i], endereco[i], fone[i], idade[i], peso[i]));
            }
        }


    }
}







    }
}
