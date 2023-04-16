using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlProductosMostrar : UserControl
    {
        public List<object> Lista { get => Lista; set { Lista = value; } }

        public CtrlProductosMostrar()
        {
            InitializeComponent();
        }

        private void CtrlProductosMostrar_Load(object sender, EventArgs e)
        {
            tableLayout.RowCount = Lista.Count / 6;
            tableLayout.ColumnCount = 6;

            for (int i = 0; i < tableLayout.RowCount; i++)
            {
                for (int j = 0; j < tableLayout.ColumnCount; j++)
                {
                    Button button = new Button();
                    button.Dock = DockStyle.Left;
                    button.Width = 184;
                    button.Height = 184;
                    tableLayout.Controls.Add(button, j, i);
                }
            }
        }
    }
}
