using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ecommerce.Helpers.Tests
{
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Em_Branco()
        {
            Guard.ForNullOrEmpty("", "Valor não pode ser vazio!");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Null()
        {
            Guard.ForNullOrEmpty(null, "Valor não pode ser vazio!");
        }

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void ForValidId()
        //{
        //    Guard.ForValidId(1,"id não pode ser zero");
        //}
    }
}
