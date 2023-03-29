﻿using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlProductosMostrar : UserControl
    {
        public CtrlProductosMostrar()
        {
            InitializeComponent();
        }

        private void CtrlProductosMostrar_Load(object sender, EventArgs e)
        {
            string[] aux = new string[60];
            tableLayout.RowCount = aux.Length / 6;
            tableLayout.ColumnCount = 6;

            for (int i = 0; i < tableLayout.RowCount; i++)
            {
                for (int j = 0; j < tableLayout.ColumnCount; j++)
                {
                    CtrlProducto ctrlProducto = new CtrlProducto();
                    ctrlProducto.Dock = DockStyle.Left;
                    tableLayout.Controls.Add(ctrlProducto,j,i);
                }
            }
        }
    }
}
