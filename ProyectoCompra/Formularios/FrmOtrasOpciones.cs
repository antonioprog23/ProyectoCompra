using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmOtrasOpciones : Form
    {
        public FrmBase frmBase { get; set; }

        public FrmOtrasOpciones(FrmBase frmBase)
        {
            InitializeComponent();
            this.frmBase = frmBase;
            this.ctrlOtrasOpciones1.frmBase = this.frmBase;
        }
    }
}
