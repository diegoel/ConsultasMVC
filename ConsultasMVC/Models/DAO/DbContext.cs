using System.Data.SqlClient;

namespace ConsultasMVC.Models.DAO
{
    public class DbContext
    {
        //CONEXION A LA BASE DE DATOS
        static string Cadena = "Server=DESKTOP-AMOEA6A\\SQLEXPRESS;DataBase=Practica_Patrones;Integrated Security=true";
        protected SqlConnection conexion = new SqlConnection(Cadena);
    }
}
