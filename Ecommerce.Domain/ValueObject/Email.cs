using Ecommerce.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject
{
    public class Email
    {
        public const int EnderecoMaxLenth = 254;
        public string Endereco { get; private set; }

        protected Email()
        {

        }

        public Email(string endereco)
        {
            Guard.ForNullOrEmptyDefaultMessage(endereco,"E-mail");
            Guard.StringLength("E-mail", endereco, EnderecoMaxLenth);

            if(IsValid(endereco) == false)
            {
                throw new Exception("E-mail invalido");
            }

            Endereco = endereco;
        }

        public static bool IsValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }
    }
}
