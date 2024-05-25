using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFLastLaboratory.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFLastLaboratory
{
    public partial class Form1 : Form
    {
        private ConectionDB conectionDB;

        private string[] companias = {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony"
        };

        public Form1()
        {
            InitializeComponent();

            conectionDB = new ConectionDB();
        }

        private void consoledDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarDataBtn_Click(object sender, EventArgs e)
        {
            List<Data.Models.Console> consoles = conectionDB.GetConsoles();
            consoledDataGrid.DataSource = consoles;
        }

        private void cargarSonyBtn_Click(object sender, EventArgs e)
        {
            List<Data.Models.Console> consoles = conectionDB.GetConsolesByCompany("Sony");
            consoledDataGrid.DataSource = consoles;
        }

        private void nintendoBtn_Click(object sender, EventArgs e)
        {
            List<Data.Models.Console> consoles = conectionDB.GetConsolesByCompany("Nintendo");
            consoledDataGrid.DataSource = consoles;
        }

        private void segaBtn_Click(object sender, EventArgs e)
        {
            List<Data.Models.Console> consoles = conectionDB.GetConsolesByCompany("Sega");
            consoledDataGrid.DataSource = consoles;
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idText.Text);
            Data.Models.Console console = conectionDB.GetConsoleById(id);
            nombreText.Text = console.NombreConsola;
            companiaBox.Text = console.Compania;
            lanzamientoNum.Text = console.AnioLanzamiento.ToString();
            generacionNum.Text = console.Generacion.ToString();
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            string nombre = nombreText.Text;
            string compania = companiaBox.Text;
            int lanzamiento = Convert.ToInt32(lanzamientoNum.Text);
            byte generacion = Convert.ToByte(generacionNum.Text);

            Data.Models.Console console = new Data.Models.Console(0, nombre, compania, lanzamiento, generacion);
            conectionDB.InsertConsole(console);

            List<Data.Models.Console> consoles = conectionDB.GetConsoles();
            consoledDataGrid.DataSource = consoles;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            companiaBox.Items.AddRange(companias);
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            string nombre = nombreText.Text;
            string compania = companiaBox.Text;
            int lanzamiento = Convert.ToInt32(lanzamientoNum.Text);
            byte generacion = Convert.ToByte(generacionNum.Text);

            Data.Models.Console console = new Data.Models.Console(0, nombre, compania, lanzamiento, generacion);
            conectionDB.UpdateConsole(console);

            List<Data.Models.Console> consoles = conectionDB.GetConsoles();
            consoledDataGrid.DataSource = consoles;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idText.Text);
            conectionDB.DeleteConsole(id);

            List<Data.Models.Console> consoles = conectionDB.GetConsoles();
            consoledDataGrid.DataSource = consoles;
        }
    }
}
