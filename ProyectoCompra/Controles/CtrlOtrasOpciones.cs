using ProyectoCompra.Enumerados;
using ProyectoCompra.Formularios;
using ProyectoCompra.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlOtrasOpciones : UserControl
    {
        public CtrlOtrasOpciones()
        {
            InitializeComponent();
        }

        private void CtrlOtrasOpciones_Load(object sender, EventArgs e)
        {
            cargarBotones();
        }

        private void cargarBotones()
        {
            int contador = 0;
            for (int i = 0; i < tbOpciones.RowCount; i++)
            {
                for (int j = 0; j < tbOpciones.ColumnCount; j++)
                {
                    if (contador < tbOpciones.ColumnCount)
                    {
                        Button button = new Button();
                        button.Width = 145;
                        button.Height = 145;
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatAppearance.BorderColor = Color.White;
                        button.FlatAppearance.MouseOverBackColor = Color.White;
                        button.FlatAppearance.MouseDownBackColor = Color.White;
                        button.Name = "op_" + contador.ToString();
                        button.Image = Resources.ResourceManager.GetObject(string.Format("op_{0}", contador)) as Image;
                        button.TextAlign = ContentAlignment.BottomCenter;
                        button.Text = setTextBotones(contador);
                        button.Click += Boton_Click;
                        tbOpciones.Controls.Add(button);
                        contador++;
                    }
                }
            }
        }

        private string setTextBotones(int contador)
        {
            string nameEnumerado = Enum.GetName(typeof(EOtrasOpciones), contador);
            string[] data = nameEnumerado.Split('_');
            string texto = "";
            foreach (string aux in data)
            {
                texto += aux + " ";
            }
            return texto;
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "op_0": //METODO DE PAGO

                    break;
                case "op_1": //PEDIDOS
                    FrmHistorialPedidos frmHistorialPedidos = new FrmHistorialPedidos();
                    frmHistorialPedidos.ShowDialog();
                    break;
                case "op_2": //DIRECCIONES

                    break;
                case "op_3": //DARSE DE BAJA

                    break;
            }
        }
    }
}
