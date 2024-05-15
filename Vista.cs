using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefericoSanBernardo.assets;

namespace TelefericoSanBernardo
{
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
            logo.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelResultados.BackColor = Color.FromArgb(150, 0, 0, 0);
            botonSimular.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void botonSimular_Click(object sender, EventArgs e)
        {
            Simulacion simulacion = new Simulacion();
            sourceSimulacion.Clear();
            sourceSimulacion.Add(simulacion);
        }
    }
}
