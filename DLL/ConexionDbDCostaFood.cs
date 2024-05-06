using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ConexionDbDCostaFood
    {
        #region Variables privadas
        private string _nombreDB;
        private string _servidor;
        private string _usuario;
        private string _contraseña;
        private bool _autenticacion; // Permite utilizar ambos métodos de conexión de SQL
        private static ConexionDbDCostaFood conexionDbDCosta = null;
        #endregion
        #region Contructor
        private ConexionDbDCostaFood()
        {
            this._nombreDB = "DB_DCostaFood";
            this._servidor = "DESKTOP-436R09O\\SQLEXPRESS";
            this._usuario = "admin";
            this._contraseña = "Seb@s123";
            this._autenticacion = true; // true = método de autenticación de windows

        }
        #endregion
        #region Metodos Publicos
        public SqlConnection CrearConexion()
        {
            #region Variable de la conexión
            SqlConnection cadenaConexion = new SqlConnection();
            #endregion
            try
            {
                cadenaConexion.ConnectionString = $"Servidor =  { this._servidor} ;  DataBase =  {this._nombreDB}" ;
                // Validación tipo de seguridad de conexión 
                if (this._autenticacion )
                {
                    cadenaConexion.ConnectionString = cadenaConexion.ConnectionString + "Integrado seguridad = SSPI ";
                } 
                else
                {
                    cadenaConexion.ConnectionString = cadenaConexion.ConnectionString + $"Usuario = { this._usuario}  ; Contraseña =  { this._contraseña}";     
                }
            }
            catch (Exception ex)
            {

                cadenaConexion = null;
                throw ex; 
                
            }
            return cadenaConexion;

        }
        //Instancia del contructor
        public static ConexionDbDCostaFood InstanciaConexion()
        {
            if (conexionDbDCosta == null)
            {
                //Crea la conexión si no existe
                conexionDbDCosta = new ConexionDbDCostaFood();
            }
            return conexionDbDCosta;
        }
        #endregion
    }
}
