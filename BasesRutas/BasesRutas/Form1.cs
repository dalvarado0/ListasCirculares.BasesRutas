using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasesRutas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Base nueva;
        Tour trip = new Tour();

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            nueva = new Base();
            nueva.name = txbNameBase.Text;
            nueva.time = Convert.ToInt32(txbTime.Text);
            trip.agregarInicio(nueva);
            nueva = null;      
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            trip.eliminar(txbDelate.Text);
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            nueva = new Base();
            nueva.name = txbNameBase.Text;
            nueva.time = Convert.ToInt32(txbTime.Text);
            trip.agregar(nueva);
            nueva = null;
        }

        private void btnDelateLast_Click(object sender, EventArgs e)
        {
            trip.eliminarUltimo();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            txbReport.Text = trip.reporte();
        }

        private void btnDelateFirst_Click(object sender, EventArgs e)
        {
            trip.eliminarPrimero();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (trip.buscar(txbSearch.Text) == null)
                txbReport.Text = "No info";
            else
                txbReport.Text = trip.buscar(txbSearch.Text).ToString();
        }
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    nueva = new Base();
        //    nueva.name = txbNameBase.Text;
        //    nueva.time = Convert.ToInt32(txbTime.Text);
        //    trip.agregar(nueva);
        //    nueva = null;
        //}
    }
}
