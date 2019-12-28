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
    public class CepTests
    {
        [TestMethod]
        public void Cep_Valido()
        {
            var cep = "08223-480";
            var obj = new Cep(cep);
            Assert.AreEqual(08223480, obj.CepCod);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_InValido()
        {
            var cep = "dfjdklj";
            var obj = new Cep(cep);
        }

        [TestMethod]
        public void Cep_GetCepFormatado08223480()
        {
            var cep = "08223-480";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        public void Cep_GetCepFormatada00000000()
        {
            var cep = "00000-000";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        public void Cep_GetCepFormatado12345678()
        {
            var cep = "12345-678";
            var obj = new Cep(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }
    }
}
