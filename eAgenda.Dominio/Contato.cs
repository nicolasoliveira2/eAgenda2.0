using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace eAgenda.Dominio
{
    public class Contato : EntidadeBase, IEnumerable
    {
        private string nome, email, telefone;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public bool EstaEmCompromisso  { get; set; }

        public Contato()
        {

        }
        public override string ToString()
        {

            return $"ID: {id} Nome: {Nome} Email: {Email} Telefone: {Telefone} Empresa: {Empresa} Cargo: {Cargo}";
        }

        public override string Validar()
        {
            StringBuilder  sb = new();

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine("Campo Nome é obrigatorio");
            if (string.IsNullOrEmpty(Email))
                sb.AppendLine("Campo Email é obrigatorio");
            if (string.IsNullOrEmpty(Telefone))
                sb.AppendLine("Campo Telefone é obrigatorio");

            EmailAddressAttribute email = new();
            if (!email.IsValid(Email))
                sb.AppendLine("E-mail não válido");

            string telefonePadrao = @"^\([1-9]{2}\) (?:[2-8]|9 [1-9])[0-9]{3}\-[0-9]{4}$";
            if (!Regex.Match(Telefone, telefonePadrao).Success)
                sb.AppendLine("Telefone não válido (xx) x xxxx-xxxx");

            if (sb.Length == 0)
                sb.AppendLine("REGISTRO_VALIDO");

            return sb.ToString().Trim();                        
        }
        public string RetornarNome()
        {
            string nome = Nome;
            return nome;
        }

        //para não dar erro do IEnumerable - NAO MEXE
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
