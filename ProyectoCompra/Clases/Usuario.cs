using ProyectoCompra.Base_datos;

namespace ProyectoCompra.Clases
{
    public class Usuario
    {
        //CONSTANTES
        private const char SEPARADOR = ';';
        public int idUsuario { get; set; }
        public Cliente cliente { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fechaAlta { get; set; }
        public int invitado { get; set; }
        public string fechaUltimaModificacion { get; set; }

        public Usuario(int idUsuario, Cliente cliente, string username, string password, string fechaAlta, string fechaUltimaModificacion)
        {
            this.idUsuario = idUsuario;
            this.cliente = cliente;
            this.username = username;
            this.password = password;
            this.fechaAlta = fechaAlta;
            this.fechaUltimaModificacion = fechaUltimaModificacion;
        }

        public Usuario(Cliente cliente) { this.cliente = cliente; }

        public Usuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public Usuario(string username, string password, int invitado)
        {
            this.username = username;
            this.password = password;
            this.invitado = invitado;
            if (invitado == 1)
            {
                this.idUsuario = BDUsuario.consultarIdUsuarioInvitado();
            }
        }
    }
}
