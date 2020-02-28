using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jkh
{
    public partial class LC_initerface : Form
    {
        public LC_initerface()
        {
            InitializeComponent();
        }

        private void LC_initerface_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.current_row.ToString());
        }
    }
}
