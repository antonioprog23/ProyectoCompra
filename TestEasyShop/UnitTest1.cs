using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;

namespace TestEasyShop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsuarioLogOut()
        {
            int referenciaUsuario = ConfigSesion.obtenerReferenciaIdUsuario();
            Assert.AreEqual(0, referenciaUsuario);
        }

        [TestMethod]
        public void ConsultarUserNameDisponible1()
        {
            Assert.AreNotEqual(0, BDUsuario.consultarUsuarioName("antonio123"));
        }

        [TestMethod]
        public void ConsultarUserNameDisponible2()
        {
            Assert.AreEqual(0, BDUsuario.consultarUsuarioName("antonio"));
        }

        [TestMethod]
        public void UsuarioLogIn()
        {
            Assert.AreNotEqual(0, BDUsuario.obtenerDatos("antonio123", "1234", ""));
        }

        [TestMethod]
        public void algo()
        {

        }
    }
}