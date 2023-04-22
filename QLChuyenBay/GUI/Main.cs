using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void ButtonAddPlaneClick(object sender, EventArgs e)
        {
            Plane obj = (Plane)sender;
            Plane_Func.AddPlane(obj);
        }

        private void ButtonUpdatePlaneClick(object sender, EventArgs e)
        {
        }

        private void ButtonDeletePlaneClick(object sender, EventArgs e)
        {

        }
    }
}