using ConsultasMVC.Controllers;
using System.Windows.Forms;

namespace ConsultasMVC.Views
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
            ClienteController ctrl = new ClienteController(this);

        }
    }
}
