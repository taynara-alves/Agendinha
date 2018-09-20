using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    class Contato // MODEL
    {
        #region Atributos
        private string email;
        private string nome;
        private string telefone;


        #endregion

        #region Propriedades
        
public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }
        #endregion

        #region Construtores
        public Contato (string email, string nome, string telefone)
        {
            this.Email = email;
            this.Nome = nome;
            this.Telefone = telefone;

        }
        public Contato(string email)
        {
            this.Email = email;
            
        }
        public Contato() : this("","","")
        {

        }

        #endregion

        #region Sobreescritas
        public override bool Equals(object obj)
        {
            Contato c = (Contato)obj;
            return this.Email.Equals(c.Email);
        }
        #endregion

        #region metodos
        public string dados()
        {
            return " Nome:" + this.Nome.ToString()  + "  " +  " Email: " + this.Email + "  " + " Telefone:" +
            this.Telefone.ToString();
        }

        #endregion
    }
}
