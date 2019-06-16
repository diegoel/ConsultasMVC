using ConsultasMVC.Models.DAO;
using ConsultasMVC.Views;
using System;

namespace ConsultasMVC.Controllers
{
    class ClienteController
    {
        //ATRIBUTO
        ClienteView Vista;
        //CONSTRUCTOR
        public ClienteController(ClienteView View)
        {
            //INICIALIZAR VISTA CON EL PARAMETRO DE ENTRADA, SIRVE COMO INSTANCIA PARA PODER ACCEDER A TODOS LOS ELEMENTOS DE CLIENTEVIEW
            Vista = View;
            //INICIALIZAR EVENTOS DE CLIENTEVIEW
            // += instancia de manejador de eventos
            Vista.Load += new EventHandler(ClienteList);
            Vista.btnBuscar.Click += new EventHandler(ClienteList);
            Vista.txtBuscar.TextChanged += new EventHandler(ClienteList);
        }
        
        //METODO PARA LISTAR CLIENTES
        //COMO PARAMETROS SE LE PASA UN OBJETO REMITENTE QUE ES LA FUENTE DEL EVENTO Y EL OBJETO EVENTO SIN DATOS 
        private void ClienteList (object sender, EventArgs e)
        {
            //SE INSTANCIA CLIENTEDAO PARA PODER INVOCAR LOS METODOS CRUD 
            ClienteDao db = new ClienteDao();
            Vista.dgvEmpleados.DataSource = db.VerRegistros(Vista.txtBuscar.Text);
        }
    }
}
