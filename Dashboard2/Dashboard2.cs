using Dashboard2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard2
{
    public partial class Dashboard2 : Form
    {

        private bool ItemPaqueteIsActivate = false;
        private bool ItemReporteIsActivate = false;
        private bool ItemAsociasionesIsActivate = false;
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelControl.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelControl.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (ItemPaqueteIsActivate==false)
            {

                ItemsPaquetes.Size = new Size(223, 201);
                button4.Image = Resources.outline_keyboard_arrow_right_white_24dp;
                ItemPaqueteIsActivate = true;
            }
            else {
                ItemsPaquetes.Size = new Size(223, 49);
                button4.Image = Resources.outline_inventory_2_white_24dp;
                ItemPaqueteIsActivate = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ItemReporteIsActivate == false)
            {
                ReportesItems.Size = new Size(223, 201);
                button8.Image = Resources.outline_keyboard_arrow_right_white_24dp;
                ItemReporteIsActivate = true;
            }
            else {
                ReportesItems.Size = new Size(223, 49);
                button8.Image = Resources.outline_description_white_24dp;
                ItemReporteIsActivate = false;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ItemAsociasionesIsActivate == false)
            {
                EmpresaItems.Size = new Size(223, 201);
                button12.Image = Resources.outline_keyboard_arrow_right_white_24dp;
                ItemAsociasionesIsActivate = true;
            }
            else {
                EmpresaItems.Size = new Size(223, 49);
                button12.Image = Resources.outline_storefront_white_24dp;
                ItemAsociasionesIsActivate = false;
            }
        }
    }
}
