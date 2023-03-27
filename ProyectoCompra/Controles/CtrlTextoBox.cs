using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlTextoBox : UserControl
    {
        private bool isNumerico;

        public CtrlTextoBox()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Tipo TextBox")]
        public bool IsNumerico { get => isNumerico; set => isNumerico = value; }

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

        public string Texto { get { return textBox.Text; } set { textBox.Text = value; } }
    }
}
