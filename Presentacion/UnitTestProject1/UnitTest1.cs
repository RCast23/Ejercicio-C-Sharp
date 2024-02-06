using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negocio;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Negocio.EntitiesDTO.LibrosDTO libroEjemplo = new Negocio.EntitiesDTO.LibrosDTO();
                libroEjemplo.Nombre = "Prueba";
                libroEjemplo.Autor = "Ejemplo";
                libroEjemplo.FechaPublicacion = DateTime.Now;
                libroEjemplo.idCategoria = 1;

                new Negocio.Management.LibroManagement().AltaLibro(libroEjemplo);
                Assert.IsTrue(true, "El alta ha sido correcta");
            }catch(Exception ex)
            {
                Assert.IsTrue(false, "El alta ha sido incorrecta");
            }
        }
    }
}
