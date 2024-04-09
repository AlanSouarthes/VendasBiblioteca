using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VendasBiblioteca
{
    class Pessoa
    {
        //Encapsulamento = Deixar as variaveis privadas
        private long CPF;
        private string nome;
        private string endereco;
        private string telefone;
        private DateTime dtNascimento;
        private string login;
        private string senha;
        private string situacao;//Ativo ou Inativo
        private string posicao;//Atendente ou Adminstrador ou Cliente

        //Metodo construtor
        public Pessoa()
        {
            ModificarCPF = 0;
            ModificarNome = "";
            ModificarTelefone = " ";
            ModificarDtNascimento = new DateTime();//"00/00/0000/ 00:00:00"
            ModificarLogin = "";
            ModificarSenha = "";
            ModificarSituacao = "";
            ModificarPosicao = "";
            
        }//Fim do Construtor
    
    
        //Metodos Modificadores = Gets e Sets
        public long ModificarCPF
        {
            get { return this.CPF; }
            set { this.CPF = value; }

        }//Fim do Modificar

        public string ModificarNome
        {
            get { return this.nome; }
            set { this.nome = value; }

        }//Fim do Modificar

        public string ModificarEndereco
        {
            get { return this.endereco; }
            set { this.endereco = value; }

        }//Fim do Modificar

        public string ModificarTelefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }

        }//Fim do Modificar

        public DateTime ModificarDtNascimento
        {
            get { return this.dtNascimento; }
            set { this.dtNascimento = value; }

        }//Fim do Modificar

        public string ModificarLogin
        {
            get { return this.login; }
            set { this.login = value; }

        }//Fim do Modificar
        public string ModificarSenha
        {
            get { return this.senha; }
            set { this.senha = value; }

        }//Fim do Modificar

        public string ModificarSituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }

        }//Fim do Modificar

        public string ModificarPosicao
        {
            get { return this.posicao; }
            set { this.posicao = value; }

        }//Fim do Modificar


        //Metodos - CRUD
        public void Cadastrar(long CPF, string nome, string telefone, string endereco,
            DateTime dtNascimento, string login, string senha,  string posicao)
        {
            ModificarCPF = CPF;
            ModificarNome = nome;
            ModificarTelefone = telefone;
            ModificarEndereco = endereco;
            ModificarDtNascimento = dtNascimento;
            ModificarLogin = login;
            ModificarSenha = senha;
            ModificarSituacao = "Ativo";
            ModificarPosicao= posicao;
        }

        public string ConsultarIndividual(long CPF)
        {
            string consulta = "";
            if (ModificarCPF == CPF)
            {
                consulta = "\nNome: " + ModificarNome +
                                  "\nTelefone: " + ModificarTelefone +
                                  "\nEndereço: " + ModificarEndereco +
                                  "\nData de Nascimento: " + ModificarDtNascimento +
                                  "\nLogin: " + ModificarLogin +
                                  "\nSenha : " + ModificarSenha +
                                  "\nSituação: " + ModificarSituacao +
                                  "\nPosição : " + ModificarPosicao;


            }
            else
            {
                consulta = "Numero de CPF não é válido !";
            }
            return consulta;
        }//Fim do Metodo

        public void AtualizarTelefone(long CPF, string telefone)
        {
            if(ModificarCPF == CPF)
            {
                ModificarTelefone = telefone;

            }

        }
        public void AtualizarNome(long CPF, string nome)
        {
            if (ModificarCPF == CPF)
            {
                ModificarTelefone = nome;
            }

        }
        public void AtualizarEndereco(long CPF, string endereco)
        {
            if (ModificarCPF == CPF)
            {
                ModificarEndereco = endereco;
            }

        }
        public void AtualizarDtNascimento(long CPF, DateTime dtNascimento)
        {
            if (ModificarCPF == CPF)
            {
                ModificarDtNascimento = dtNascimento;
            }

        }
        public void AtualizarSenha(long CPF, string senha)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSenha = senha;
            }

        }
        public void AtualizarSituacao(long CPF, string situacao)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSituacao = situacao;
            }

        }
        public void AtualizarPosicao(long CPF, string posicao)
        {
            if (ModificarCPF == CPF)
            {
                ModificarPosicao = posicao;
            }

        }//Fim do Metodo

        public void Excluir(long CPF)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSituacao = " Inativo";
            }
        }//Fim do Metodo

        internal void AtualizarDataNascimento(long cPF, DateTime data)
        {
            throw new NotImplementedException();
        }
    }//Fim da classe
}//Fim do projeto
