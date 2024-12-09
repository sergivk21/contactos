using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoelhoGalvan
{
    public partial class Form1 : Form
    {
        // Lista de contactos
        private List<Contacto> contactos;

        public Form1()
        {
            InitializeComponent();
            contactos = new List<Contacto>();
        }

        // Validar número de teléfono
        private bool ValidarTelefono(string telefono)
        {
            // Verifica si el teléfono está vacío.
            if (string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("El número de teléfono no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica la longitud del teléfono.
            if (telefono.Length != 9)
            {
                MessageBox.Show("El número de teléfono debe tener 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica si contiene solo números.
            if (!long.TryParse(telefono, out _))
            {
                MessageBox.Show("El número de teléfono debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // El teléfono es válido.
        }

        // Mostrar contactos en el ListBox
        private void ActualizarListaContactos()
        {
            listContactos.Items.Clear();
            foreach (var contacto in contactos)
            {
                listContactos.Items.Add($"{contacto.Nombre} - {contacto.Telefono}");
            }
        }


        private void insertar_Click_1(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarTelefono(telefono)) return;

            contactos.Add(new Contacto { Nombre = nombre, Telefono = telefono });
            MessageBox.Show("Contacto añadido correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarListaContactos();
        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();

            if (!ValidarTelefono(telefono)) return;

            var contacto = contactos.Find(c => c.Telefono == telefono);
            if (contacto == null)
            {
                MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Contacto encontrado:\nNombre: {contacto.Nombre}\nTeléfono: {contacto.Telefono}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void actualizar_Click_1(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();

            if (!ValidarTelefono(telefono)) return;

            var index = contactos.FindIndex(c => c.Telefono == telefono);
            if (index == -1)
            {
                MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nuevoNombre = txtNombre.Text.Trim();
                if (string.IsNullOrEmpty(nuevoNombre))
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                contactos[index].Nombre = nuevoNombre;
                MessageBox.Show("Contacto actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaContactos();
            }
        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();

            if (!ValidarTelefono(telefono)) return;

            var contacto = contactos.Find(c => c.Telefono == telefono);
            if (contacto == null)
            {
                MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contactos.Remove(contacto);
                MessageBox.Show("Contacto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaContactos();
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.ForeColor = Color.Black;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
            txtTelefono.ForeColor = Color.Black;
        }
    }

    // Clase Contacto
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}

        

      

      

        

        

