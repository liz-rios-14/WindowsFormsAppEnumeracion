using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEnumeracion
{
    // Definimos una enumeración llamada EstadoPedido
    // Representa los distintos estados que puede tener un pedido
    public enum EstadoPedido
    {
        Pendiente,
        Procesando,
        Enviado,
        Entregado,
        Cancelado
    }
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            // Al iniciar el formulario, cargamos los valores del enum EstadoPedido en el ComboBox
            // Esto permite que el usuario seleccione un estado desde el menú desplegable
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoPedido)); 
        } 
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Obtenemos el estado seleccionado en el ComboBox y lo convertimos al tipo EstadoPedido
            EstadoPedido estadoSeleccionado = (EstadoPedido)cmbEstado.SelectedItem;

            // Evaluamos el estado con un switch para mostrar un mensaje correspondiente
            switch (estadoSeleccionado)
            {
                case EstadoPedido.Pendiente:
                    lblResultado.Text = "Tu pedido está pendiente.";
                    break;
                case EstadoPedido.Procesando:
                    lblResultado.Text = "Tu pedido está siendo procesado.";
                    break;
                case EstadoPedido.Enviado:
                    lblResultado.Text = "Tu pedido ha sido enviado.";
                    break;
                case EstadoPedido.Entregado:
                    lblResultado.Text = "Tu pedido fue entregado.";
                    break;
                case EstadoPedido.Cancelado:
                    lblResultado.Text = "Tu pedido fue cancelado.";
                    break;
                default:
                    // En caso de seleccionar un valor no esperado 
                    lblResultado.Text = "Estado desconocido.";
                    break;
            }

        }
    }
}
