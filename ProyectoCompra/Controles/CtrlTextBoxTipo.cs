using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoCompra.Controles
{
    public partial class CtrlTextBoxTipo : UserControl
    {
        private bool isNumerico;
        public CtrlTextBoxTipo()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Tipo TextBox")]
        public bool IsNumerico { get => isNumerico; set => isNumerico = value; }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            // Ajustar el tamaño y la posición del control en relación con el formulario contenedor
            this.Width = this.Parent.ClientSize.Width;
            this.Height = this.Parent.ClientSize.Height;
            this.Location = new Point(0, 0);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (isNumerico)
            {
                Regex regex = new Regex("[^0-9]");
                textBox.Text = regex.Replace(textBox.Text, "");
                textBox.Select(textBox.Text.Length, 0);
            }
            else
            {
                Regex regex = new Regex("[^a-zA-Z]");
                textBox.Text = regex.Replace(textBox.Text, "");
                textBox.Select(textBox.Text.Length, 0);
            }
        }
    }




}
