using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMetodosListas
{
    public partial class Form1: Form
    {
        // Creamos una lista de cadenas para almacenar los elementos que el usuario agregue
        private List<string> elementos = new List<string>();

        public Form1()
        {
            // Inicializa todos los componentes visuales del formulario (botones, cajas de texto, etc.)
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtenemos el texto ingresado por el usuario
            string nuevoElemento = txtElemento.Text;

            // Validamos que el texto no esté vacío ni solo con espacios
            if (!string.IsNullOrWhiteSpace(nuevoElemento))
            {
                // Agregamos el nuevo elemento a la lista
                elementos.Add(nuevoElemento);

                // Actualizamos la visualización de la lista en el ListBox
                ActualizarLista();

                // Limpiamos la caja de texto para ingresar un nuevo elemento
                txtElemento.Clear();
            }
            else
            {
                // Mostramos un mensaje si el texto ingresado no es válido
                MessageBox.Show("Por favor ingresa un elemento válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay un elemento seleccionado en el ListBox
            if (lstElementos.SelectedItem != null)
            {
                // Eliminamos el elemento seleccionado de la lista
                elementos.Remove(lstElementos.SelectedItem.ToString());
                // Actualizamos la visualización del ListBox
                ActualizarLista();
            }
            else
            {
                // Mostramos un mensaje si no hay ningún elemento seleccionado
                MessageBox.Show("Selecciona un elemento para eliminar.");
            }
        }
        // Método para actualizar ListBox 

        private void ActualizarLista()
        {
            // Asignamos null temporalmente para forzar la actualización del contenido
            lstElementos.DataSource = null;

            // Asignamos nuevamente la lista actualizada como fuente de datos del ListBox
            lstElementos.DataSource = elementos;
        }
    }
}
