using Ecommerce.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Tests.ValueObject
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Em_Banco()
        {
            var email = new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Null()
        {
            var email = new Email(null);
        }

        [TestMethod]
        public void Email_New_Email_Valido()
        {
            var endereco = "anoemangi@outlook.com";
            var email = new Email(endereco);
            Assert.AreEqual(endereco, email.Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Invalido()
        {
            var email =new Email("djsdussgifguusgfdsfis");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Max()
        {
            var endereco = "anoemangi@outlook.com";
            while(endereco.Length < Email.EnderecoMaxLenth + 1)
            {
                endereco = endereco + "anoemangi@outlook.com";
            }

           new Email(endereco);
        }
    }
}
