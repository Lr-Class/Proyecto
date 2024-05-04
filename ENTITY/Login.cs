namespace ENTITY
{
    public class Login
    {
        private string _nombreUsuario;
        private string _Contraseña;
        public Login(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
    }
}
