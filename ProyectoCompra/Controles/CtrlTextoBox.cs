using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlTextoBox : UserControl
    {
        private bool isNumerico;
        private bool isReadOnly;

        public CtrlTextoBox()
        {
            InitializeComponent();
        }

        public string Texto { get { return textBox.Text; } set { textBox.Text = value; } }

        //PROPIEDADES
        [Category("Personalizado")]
        [DisplayName("Es numérico")]
        [Description("Indica si el control solo permite ingresar valores numéricos.")]
        [DefaultValue(false)]
        public bool IsNumerico
        {
            get => isNumerico;
            set
            {
                isNumerico = value;
                if (isNumerico)
                {
                    Regex regex = new Regex("[^0-9]");
                    textBox.Text = regex.Replace(textBox.Text, "");
                    textBox.Select(textBox.Text.Length, 0);
                }
                else
                {
                    Regex regex = new Regex("[^a-zA-Z ]");
                    textBox.Text = regex.Replace(textBox.Text, "");
                    textBox.Select(textBox.Text.Length, 0);
                }
            }
        }

        [Category("Personalizado")]
        [DisplayName("IsReadOnly")]
        [Description("Indica si el control es solo de lectura.")]
        [DefaultValue(false)]
        public bool IsReadOnly
        {
            get => isReadOnly;
            set
            {
                textBox.ReadOnly = value;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (isNumerico && !isReadOnly)
            {
                Regex regex = new Regex("[^0-9]");
                textBox.Text = regex.Replace(textBox.Text, "");
                textBox.Select(textBox.Text.Length, 0);
            }
            if (!isNumerico && !isReadOnly)
            {
                Regex regex = new Regex("[^a-zA-Z ]");
                textBox.Text = regex.Replace(textBox.Text, "");
                textBox.Select(textBox.Text.Length, 0);
            }
            if (isReadOnly)
            {
                textBox.ReadOnly = true;
            }
            else
            {
                textBox.ReadOnly = false;
            }
        }
    }
}
