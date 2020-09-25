using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Test
{
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]
        public void ContarDivisoresDeSeis()
        {
            //Arrange
            ApplicationCore.Services.Utilities utilities = new ApplicationCore.Services.Utilities();
            var numero = 6;

            //Act
            var result = utilities.ContarDivisores(numero);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ObtenerValorProductoMouse()
        {
            //Arrange
            ApplicationCore.Services.Utilities utilities = new ApplicationCore.Services.Utilities();
            var codigo = 1250;

            //Act
            var result = utilities.ObtenerValorProducto(codigo);

            //Assert
            Assert.AreEqual(15500, result);
        }

        [TestMethod]
        public void ObtenerValorProductoImpresora()
        {
            //Arrange
            ApplicationCore.Services.Utilities utilities = new ApplicationCore.Services.Utilities();
            var codigo = 1260;

            //Act
            var result = utilities.ObtenerValorProducto(codigo);

            //Assert
            Assert.AreEqual(678000, result);
        }

        [TestMethod]
        public void ObtenerValorProductoMemoriaUsb()
        {
            //Arrange
            ApplicationCore.Services.Utilities utilities = new ApplicationCore.Services.Utilities();
            var codigo = 1270;

            //Act
            var result = utilities.ObtenerValorProducto(codigo);

            //Assert
            Assert.AreEqual(35000, result);
        }

        [TestMethod]
        public void ObtenerValorProductoDiscoDuro500()
        {
            //Arrange
            ApplicationCore.Services.Utilities utilities = new ApplicationCore.Services.Utilities();
            var codigo = 1280;

            //Act
            var result = utilities.ObtenerValorProducto(codigo);

            //Assert
            Assert.AreEqual(180000, result);
        }

        [TestMethod]
        public void ObtenerValorProductoMonitor()
        {
            //Arrange
            ApplicationCore.Services.Utilities utilities = new ApplicationCore.Services.Utilities();
            var codigo = 1290;

            //Act
            var result = utilities.ObtenerValorProducto(codigo);

            //Assert
            Assert.AreEqual(280000, result);
        }


    }
}
