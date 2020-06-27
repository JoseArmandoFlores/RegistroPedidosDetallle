using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroPedidos.BLL;
using RegistroPedidos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroPedidos.BLL.Tests
{
    [TestClass()]
    public class OrdenesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Ordenes orden = new Ordenes();

            orden.OrdenId = 0;
            orden.Fecha = DateTime.Now;
            orden.SuplidorId = 1;
            orden.OrdenesDetalle = new List<OrdenesDetalle>();
            orden.Monto = 100;

            paso = OrdenesBLL.Guardar(orden);
            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Ordenes orden = new Ordenes();

            orden.OrdenId = 1;
            orden.Fecha = DateTime.Now;
            orden.SuplidorId = 1;
            orden.OrdenesDetalle = new List<OrdenesDetalle>();
            orden.Monto = 5;

            paso = OrdenesBLL.Modificar(orden);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = OrdenesBLL.Eliminar(1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Ordenes orden;
            orden = OrdenesBLL.Buscar(1);

            Assert.IsNotNull(orden);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Ordenes> lista;
            lista = OrdenesBLL.GetList(p => true);

            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool encontrado = false;
            encontrado = OrdenesBLL.Existe(1);

            Assert.AreEqual(encontrado, true);
        }
    }
}