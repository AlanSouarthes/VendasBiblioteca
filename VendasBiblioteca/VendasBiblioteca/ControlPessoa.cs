﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VendasBiblioteca
{
   class ControlPessoa
    {
        Pessoa model;//Conectar com a classe pessoa
        private int opcao;
        public ControlPessoa() 
        {
            model = new Pessoa();//Acesssi a todos mnetodos da classe pessoa
            ModificarOpcao = 0;
        }
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }
        public void Menu()
        {
            Console.WriteLine("Menu - Pessoa"                       +
                              "\nEscolha uma das opçoes abaixo: "   +
                              "\n1. Cadastrar Pessoa"               +
                              "\n2. Consultar pessoa"               +
                              "\n3. Atualizar Nome"                 +
                              "\n4. Atualizar Telefone"             +
                              "\n5. Atualizar Endereço"             +
                              "\n6. Atualizar Data de Nascimento"   +
                              "\n7. Atualizar senha"                +
                              "\n8. Atualizar Situação"             +
                              "\n9. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do menu

        public void Operacao()
        {
            Menu();//Mostar Menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o CPF: ");
                    long CPF = Convert.ToInt64(Console.ReadLine());
                    

                    Console.WriteLine("Informe o seu nome: ");
                    string nome = Console.ReadLine();
                    

                    Console.WriteLine("Informe seu telefone: ");
                    string telefone = Console.ReadLine();
                    

                    Console.WriteLine("Informe seu endereço: ");
                    string endereco = Console.ReadLine();
                    

                    Console.WriteLine("Informe sua data de nascimento: ");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Informe seu login: ");
                    string login = Console.ReadLine();

                    Console.WriteLine("Informe sua senha");
                    string senha = Console.ReadLine();

                    Console.WriteLine("Informe seu cargo");
                    string cargo = Console.ReadLine();

                    //Chamar o metodo construtor
                    model.Cadastrar(CPF, nome, telefone, endereco, data, login, senha, cargo);
                    break;

                case 2:
                    Console.WriteLine("Informe o CPF que deseja consultar");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Mostrar os dados
                    Console.WriteLine(model.ConsultarIndividual(CPF));
                    break;

                case 3:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo nome: ");
                    nome = Console.ReadLine();
                    

                    //Atualizar
                    model.AtualizarNome(CPF, nome);
                    break;

                case 4:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo telefone: ");
                    telefone = Console.ReadLine();
                   

                    //Atualizar
                    model.AtualizarTelefone(CPF, telefone);
                    break;

                case 5:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo endereço: ");
                    endereco = Console.ReadLine();


                    //Atualizar
                    model.AtualizarEndereco(CPF, endereco);
                    break;

                case 6:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a nova Data de nascimento: ");
                    data = Convert.ToDateTime(Console.ReadLine());


                    //Atualizar
                    model.AtualizarDataNascimento(CPF, data);
                    break;

                case 7:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe uma nova senha: ");
                    senha = Console.ReadLine();


                    //Atualizar
                    model.AtualizarSenha(CPF, senha);
                    break;

                case 8:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o cargo: ");
                    cargo = Console.ReadLine();


                    //Atualizar
                    model.AtualizarPosicao(CPF, cargo);
                    break;

                case 9:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    model.Excluir(CPF);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
        }


    }//Fim da Classe
}//Fim do Projeto
