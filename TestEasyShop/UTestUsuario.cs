using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Enumerados;

namespace TestEasyShop
{
    [TestClass]
    public class UTestUsuario
    {
        [TestMethod]
        public void UsuarioDadoAlta()
        {
            Cliente cliente = new Cliente("Prueba", "Prueba", 23, "23/08/1999", "Masculino", "antajc23@gmail.com");
            Usuario usuario = new Usuario("prueba", "1234", 0);
            bool isAlta = BDUsuario.insertarDatos(cliente, usuario);
            Assert.AreEqual(true, isAlta);
        }

        [TestMethod]
        public void ActualizarDatosUsuario()
        {
            bool actualizado = BDUsuario.actualiarDatos("prueba", "12345", "correoprueba@gmail.com");
            Assert.AreEqual(true, actualizado);
        }

        [TestMethod]
        public void AgregarProductoToCarrito()
        {
            int idUsuario = BDUsuario.consultarUsuarioName("prueba");
            Usuario usuario = new Usuario(idUsuario);
            Producto producto = new Producto(1);
            Carrito carrito = new Carrito(1, producto);
            bool insertado = carrito.insertarProducto(usuario, carrito, false);
            Assert.AreEqual(true, insertado);
        }

        [TestMethod]
        public void EliminarProductoFromCarrito()
        {
            int idUsuario = BDUsuario.consultarUsuarioName("prueba");
            Carrito carrito = new Carrito();
            carrito.vaciarCarrito(idUsuario, 1, false);
        }

        [TestMethod]
        public void AgregarProductoToCarrito2()
        {
            int idUsuario = BDUsuario.consultarUsuarioName("prueba");
            Usuario usuario = new Usuario(idUsuario);
            Producto producto = new Producto(1);
            Carrito carrito = new Carrito(1, producto);
            bool insertado = carrito.insertarProducto(usuario, carrito, false);
            Assert.AreEqual(true, insertado);
        }

        [TestMethod]
        public void AgregarDireccionUsuario()
        {
            int idUsuario = BDUsuario.consultarUsuarioName("prueba");
            Direccion direccion = new Direccion("Casa", "C/Capricornio, 1", "España", "Zaragoza", "Zaragoza", "50012", "600123321");
            bool actualizado = BDDireccion.actualizarDireccion(direccion, idUsuario);
            Assert.AreEqual(true, actualizado);
        }

        [TestMethod]
        public void realizarCompra()
        {
            int idUsuario = BDUsuario.consultarUsuarioName("prueba");
            bool actualizado = BDPedido.actualizarPedido(idUsuario, (int)EMetodoPago.Efectivo);
            Assert.AreEqual(true, actualizado);
        }

        [TestMethod]
        public void DarBajaUsuarioUsandoUserNameYContrasenia()
        {
            bool isBaja = BDUsuario.darBajaUsuarioPorUsuario("prueba", "12345");
            Assert.AreEqual(true, isBaja);
        }
    }
}