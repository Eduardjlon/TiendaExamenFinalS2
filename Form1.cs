
namespace TiendaExaFinalS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            costumizeDesign();
           
        }
        private void costumizeDesign()
        {
            panelSubMenu.Visible = false;
            panelMenu2.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            if (panelMenu2.Visible == true)
                panelMenu2.Visible = false;
        }
        private void showSubMenus(Panel subMenus)
        {
            if (subMenus.Visible == false)
            {
                hideSubMenu();
                subMenus.Visible = true;
            }
            else
                subMenus.Visible = false;
        }

        private void Estudiante_Click(object sender, EventArgs e)
        {
            showSubMenus(panelSubMenu);
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            //Pendiente
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            //Pendiente
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            showSubMenus(panelMenu2);
        }

        private void IniciarSesionC_Click(object sender, EventArgs e)
        {
            //Pendiente
        }

        private void CrearUsuarioC_Click(object sender, EventArgs e)
        {
            //Pendiente
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            //Pendiente
        }
    }
}
