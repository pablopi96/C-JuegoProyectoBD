using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseDeDatosProyecto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatosProyecto.Controladores;

namespace BaseDeDatosProyecto.Clases.Tests
{
    [TestClass()]
    public class ValidacionesTests
    {
        [TestMethod()]
        public void validarNombreTest()
        {
            bool v = Helpers.validarNombre("pedro");
            Assert.AreEqual(true,v);
        }
    }
}