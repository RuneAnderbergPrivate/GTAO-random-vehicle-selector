using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLSerialisering;

namespace GTAO_Random_Vehicle_Selector
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public Vehicles Vehicles { get; set; }
        public Randomizer Randomizer { get; set; }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Vehicles = ObjectXmlSerializer<Vehicles>.Load("vehiclelist.xml");

            lbl_rndVehicle_SetText(RndVehicle());
        }

        private void btn_NewRandomVehicle_Click(object sender, EventArgs e)
        {
            RndVehicle();
            lbl_rndVehicle_SetText(RndVehicle());
        }

        private void lbl_rndVehicle_SetText(string text)
        {
            lbl_rndVehicle.Text = text;
        }

        private string RndVehicle()
        {
            Randomizer = new Randomizer(Vehicles);
            return Randomizer.RandomVehicle();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
