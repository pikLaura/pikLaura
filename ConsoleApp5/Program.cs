﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class Principal2
    {
        SistemaFuncionarios sistemafuncionarios = new SistemaFuncionarios();
        SistemaClientes sistemaclientes = new SistemaClientes();
        SistemaVagas sistemavagas = new SistemaVagas();


        public void SistemaClientes()
        {

            Console.Clear();
            Console.WriteLine(@"1- Cadastrar Cliente  
2- Editar Clientes   
3- Buscar Clientes  
4- Listar Clientes");
            Console.WriteLine("");
            Console.Write("Escolha sua opção: ");
            int MenuSistemaCliente = Convert.ToInt32(Console.ReadLine());

            while (MenuSistemaCliente != 20)
            {
                switch (MenuSistemaCliente)
                {
                    case 1:
                        sistemaclientes.CadastroCliente();

                        break;
                    case 2:
                        sistemaclientes.Editarcliente();
                        break;
                    case 3:
                        sistemaclientes.Buscarcliente();
                        break;
                    case 4:
                        sistemaclientes.ListarCliente();
                        break;


                }
                SistemaClientes();

            }

        }
        internal void SistemaFuncionarios()
        {
            Console.Clear();
            Console.WriteLine(@"1- Cadastrar Funcionario  
2- Editar Funcionario   
3- Buscar Funcionario   
4- Listar Funcionario");
            Console.WriteLine("");
            Console.Write("Escolha sua opção: ");
            int MenuSistemaFuncionario = Convert.ToInt32(Console.ReadLine());

            while (MenuSistemaFuncionario != 20)
            {
                switch (MenuSistemaFuncionario)
                {
                    case 1:
                        sistemafuncionarios.SistemaFuncionarios2();

                        break;
                    case 2:
                        sistemafuncionarios.EditarFuncionario();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;


                }
                SistemaFuncionarios();


            }
            SistemaVagas();
        }





        public void SistemaProdultos()
        {
            throw new NotImplementedException();
        }


        public void SistemaVagas()
        {
            Console.Clear();
            Console.WriteLine(@"1-cadastrar Vagas
2-editar Vagas
3-buacar Vagas
4-listar Vagas
20-sair");
            Console.Write("");
            Console.Write("escolha uma das opsoes: ");
            int menusistemaVagas = Convert.ToInt32(Console.ReadLine());
            while (menusistemaVagas != 20)
            {
                switch (menusistemaVagas)
                {
                    case 1:
                        sistemaclientes.cadastrarVaga();
                        break;
                    case 2:
                        sistemaclientes.editarVaga();
                        break;
                    case 3:
                        sistemaclientes.buscarVagas();
                        break;
                    case 4:
                        sistemaclientes.listatVagas();
                        break;
                    

                }
            }
        }
    }
}