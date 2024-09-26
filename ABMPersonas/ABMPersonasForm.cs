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

        //Cargar el formulario. 
        private void ABMPersonasForm_Load(object sender, EventArgs e)
        {
            listaGrupo.Enabled = true;
            edicionGrupo.Enabled = false;

            ActualizarLista();
        }

        private void borrarBoton_Click(object sender, EventArgs e)
        {
            if(personasLista.SelectedItems.Count !=1 ) //Para que borre de a 1. 
            {
                MessageBox.Show("Seleccione una y solo una persona a borrar.");
                return;
            }

            var item = personasLista.SelectedItems[0];
            var persona = (Persona)item.Tag; //Esta es la persona que tenemos que borrar. 

            var error = modelo.BorrarPersona(persona);
            if(error != null)
            {
                MessageBox.Show(error);
                return;
            }

            //Ok, la persona se borro de la lista. 
            ActualizarLista();
        }

        public void ActualizarLista() //Borro y vuelvo a cargar.
        {
            personasLista.Items.Clear();

            //Cargar la lista con datos. ---> Los datos los saco del MODELO. 
            //El modelo va a tener una lsita de personas.
            foreach (var persona in modelo.Personas)
            {
                //Agregar a la lista
                ListViewItem item = new ListViewItem();
                item.Text = persona.DNI.ToString();
                //Los subitems son cada una de las columnas siguientes. 
                item.SubItems.Add(persona.Nombre);
                item.SubItems.Add(persona.Apellido);
                item.Tag = persona;//Etiquetar cada columna o fila, para despues poder identificarlas. Se puede meter cualquier cosa (object) en el tag.
                personasLista.Items.Add(item);
            }
        }
    }
}
