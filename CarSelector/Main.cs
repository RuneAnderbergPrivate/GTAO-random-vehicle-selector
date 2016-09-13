using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSelector
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string GarageAndVehicleName(int[] input)
        {
            string[] garageNames = new string[] { "Eclipse, Penthouse Suite 3", "0120 Murrieta Heights", "Unit 2 Popular St", "3655 Wild Oats Dr", "0604 Las Laguna Blvd, Apt 4" };
            string[,] vehicleNames = new string[,] {
                {"Sultan RS (Super)", "Pfister 811 (Super)", "Zentorno (Super)", "X80 Proto (Super)", "RE-7B (Super)", "Seven-70 (Sports)", "Massacro (Racecar) (Sports)", "Jester (Racecar) (Sports)", "Voltic (Super)", "Banshee 900R (Super)"},
                {"Fränken Stange (Muscle)", "Pisswasser Dominator (Muscle)", "Coquette BlackFin (Muscle)", "Buccaneer Custom (Muscle)", "Blade (Muscle)", "Tampa (Muscle)", "Sabre Turbo (Muscle)", "Phoenix (Muscle)", "Nightshade (Muscle)", "Gauntlet (Muscle)"},
                {"Trophy Truck (Off-Road)", "Brawler (Off-Road)", "Hakuchou (Motorcycles)", "Akuma (Motorcycles)", "Panto (Compacts)", "Rumpo Custom (Vans)", "Tornado (Sports Classics)", "Peyote (Sports Classics)", "Omnis (Sports)", "Futo (Sports)"},
                {"Schafter V12 Armored (Sedans)", "BF400 (Motorcycles)", "Bati 801 (Motorcycles)", "Zion (Coupes)", "Brioso S/A (Compacts)", "Gang Burrito (Vans)", "Sadler (Utility)", "Contender (SUVs)", "Stirling GT (Sports Classics)", "Elegy RH8 (Sports)"},
                {"Tornado (Mariachi) (Sports Classics)", "Roosevelt Valor (Sports Classics)", "Kuruma (Armored) (Sports)", "Romero Hearse (Sedans)", "Insurgent (Off-Road)", "Dubsta (SUVs)","","","",""}};

            string output = (garageNames[input[0]] + "\n" + vehicleNames[input[0],input[1]]);
            
            return output;
        }

        private int[] RandomGarageAndVehicleNum()
        {
            Random rand = new Random();
            int garageRand = rand.Next(0, 45);
            int vehicleNum;
            int garageNum = 0;
            
            if (garageRand < 40)
            {
                vehicleNum = rand.Next(0, 9);
                if (garageRand < 10)
                    garageNum = 0;
                else if (garageRand < 20)
                    garageNum = 1;
                else if (garageRand < 30)
                    garageNum = 2;
                else if (garageRand < 40)
                    garageNum = 3;
            }
            else
            {
                vehicleNum = rand.Next(0, 5);
                garageNum = 4;
            }

            int[] output = new int[] {garageNum, vehicleNum};

            return output;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rtbOutput.Text = (GarageAndVehicleName(RandomGarageAndVehicleNum()));
        }
        
        private void btnNewRand_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = (GarageAndVehicleName(RandomGarageAndVehicleNum()));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
