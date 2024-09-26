using TomasSampietro.Prototipos.Ejercicio04.ABMPersonas;

namespace TomasSampietro.Prototipos.Ejercicio04
{
    public partial class ABMPersonasForm : Form
    {
        //1. Creo la referencia desde el FORMULARIO al MODELO.
        private ABMPersonasModel modelo = new ABMPersonasModel();
        public ABMPersonasForm()
        {
            InitializeComponent();
        }

        private void ABMPersonasForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
