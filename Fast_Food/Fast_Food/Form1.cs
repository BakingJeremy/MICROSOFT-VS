using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food
{
    public partial class Jeremy : Form
    {
        const double Price_Bottle = 20;
        const double Price_Fries = 30;
        const double Price_Salad = 100;
        const double Price_Hamburger = 50;
        const double Price_Onion = 50;
        const double Price_Chicken = 120;
        const double Price_Fish = 150;
        const double Price_Cheese = 80;
        const double Price_Chickensand = 100;
        const double Price_Halohalo = 35;
        const double Price_LecheFlan = 45 ;
        const double Price_Ubehalaya = 75;
        const double Price_Sapinsapin = 35;
        const double Price_Maisconyelo = 25;
        const double Price_Mountaindew = 20;
        const double Price_CocaCola = 20;
        const double Price_Royal = 20;
        const double Price_Sprite = 20;
        const double Price_Green = 120;
        const double Price_Mango = 120;
        const double Price_Papaya = 120;
        const double Price_Avocado = 120;
        const double Tax_Rate = 10;

        double iTax, iSubTotal, iTotal;

        public Jeremy()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the System", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //====================================ResetTextBoxes()====================================
        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Text = "0";
                        else
                            func(control.Controls);

                };
            func(Controls);
        }

        //====================================EnableTextBoxes()====================================
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);

            };
            func(Controls);
        }

        //====================================ResetCheckBoxes()====================================

        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);

            };
            func(Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPaymentMethod.Items.Add("");
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Gcash");
            cmbPaymentMethod.Items.Add("PayMaya");
            cmbPaymentMethod.Items.Add("Debit Card");

            EnableTextBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.Text == "Cash")
            {
                txtPaymentmethod.Enabled = true;
                txtPaymentmethod.Text = "";
                txtPaymentmethod.Focus();
            }
            else
            {
                txtPaymentmethod.Enabled = false;
                txtPaymentmethod.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFries.Checked == true)
            {
                txtFries.Enabled = true;
                txtFries.Text = "";
                txtFries.Focus();
            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkHaloHalo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalad.Checked == true)
            {
                txtSalad.Enabled = true;
                txtSalad.Text = "";
                txtSalad.Focus();
            }
            else
            {
                txtSalad.Enabled = false;
                txtSalad.Text = "0";
            }
        }

        private void chkHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHamburger.Checked == true)
            {
                txtHamburger.Enabled = true;
                txtHamburger.Text = "";
                txtHamburger.Focus();
            }
            else
            {
                txtHamburger.Enabled = false;
                txtHamburger.Text = "0";
            }
        }

        private void txthamburger_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked == true)
            {
                txtOnion.Enabled = true;
                txtOnion.Text = "";
                txtOnion.Focus();
            }
            else
            {
                txtOnion.Enabled = false;
                txtOnion.Text = "0";
            }
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken.Checked == true)
            {
                txtChicken.Enabled = true;
                txtChicken.Text = "";
                txtChicken.Focus();
            }
            else
            {
                txtChicken.Enabled = false;
                txtChicken.Text = "0";
            }
        }

        private void chkFish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFish.Checked == true)
            {
                txtFish.Enabled = true;
                txtFish.Text = "";
                txtFish.Focus();
            }
            else
            {
                txtFish.Enabled = false;
                txtFish.Text = "0";
            }
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked == true)
            {
                txtCheese.Enabled = true;
                txtCheese.Text = "";
                txtCheese.Focus();
            }
            else
            {
                txtCheese.Enabled = false;
                txtCheese.Text = "0";
            }
        }

        private void chkChickensand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickensand.Checked == true)
            {
                txtChickensand.Enabled = true;
                txtChickensand.Text = "";
                txtChickensand.Focus();
            }
            else
            {
                txtChickensand.Enabled = false;
                txtChickensand.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHalohalo.Checked == true)
            {
                txtHaloHalo.Enabled = true;
                txtHaloHalo.Text = "";
                txtHaloHalo.Focus();
            }
            else
            {
                txtHaloHalo.Enabled = false;
                txtHaloHalo.Text = "0";
            }
        }

        private void chkLecheflan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLecheflan.Checked == true)
            {
                txtLecheflan.Enabled = true;
                txtLecheflan.Text = "";
                txtLecheflan.Focus();
            }
            else
            {
                txtLecheflan.Enabled = false;
                txtLecheflan.Text = "0";
            }
        }

        private void chkUbehalaya_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUbehalaya.Checked == true)
            {
                txtUbehalaya.Enabled = true;
                txtUbehalaya.Text = "";
                txtUbehalaya.Focus();
            }
            else
            {
                txtUbehalaya.Enabled = false;
                txtUbehalaya.Text = "0";
            }
        }

        private void chkSapinsapin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSapinsapin.Checked == true)
            {
                txtSapinsapin.Enabled = true;
                txtSapinsapin.Text = "";
                txtSapinsapin.Focus();
            }
            else
            {
                txtSapinsapin.Enabled = false;
                txtSapinsapin.Text = "0";
            }
        }

        private void chkMaisconyelo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaisconyelo.Checked == true)
            {
                txtMaisconyelo.Enabled = true;
                txtMaisconyelo.Text = "";
                txtMaisconyelo.Focus();
            }
            else
            {
                txtMaisconyelo.Enabled = false;
                txtMaisconyelo.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMountain.Checked == true)
            {
                txtMountain.Enabled = true;
                txtMountain.Text = "";
                txtMountain.Focus();
            }
            else
            {
                txtMountain.Enabled = false;
                txtMountain.Text = "0";
            }
        }

        private void chkCocacola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCocacola.Checked == true)
            {
                txtCoca.Enabled = true;
                txtCoca.Text = "";
                txtCoca.Focus();
            }
            else
            {
                txtCoca.Enabled = false;
                txtCoca.Text = "0";
            }
        }

        private void chkRoyal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRoyal.Checked == true)
            {
                txtRoyal.Enabled = true;
                txtRoyal.Text = "";
                txtRoyal.Focus();
            }
            else
            {
                txtRoyal.Enabled = false;
                txtRoyal.Text = "0";
            }
        }

        private void chkSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSprite.Checked == true)
            {
                txtSprite.Enabled = true;
                txtSprite.Text = "";
                txtSprite.Focus();
            }
            else
            {
                txtSprite.Enabled = false;
                txtSprite.Text = "0";
            }
        }

        private void chkBottle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBottle.Checked == true)
            {
                txtBottle.Enabled = true;
                txtBottle.Text = "";
                txtBottle.Focus();
            }
            else
            {
                txtBottle.Enabled = false;
                txtBottle.Text = "0";
            }
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreen.Checked == true)
            {
                txtGreen.Enabled = true;
                txtGreen.Text = "";
                txtGreen.Focus();
            }
            else
            {
                txtGreen.Enabled = false;
                txtGreen.Text = "0";
            }
        }

        private void chkMango_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMango.Checked == true)
            {
                txtMango.Enabled = true;
                txtMango.Text = "";
                txtMango.Focus();
            }
            else
            {
                txtMango.Enabled = false;
                txtMango.Text = "0";
            }
        }

        private void chkPapaya_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPapaya.Checked == true)
            {
                txtPapaya.Enabled = true;
                txtPapaya.Text = "";
                txtPapaya.Focus();
            }
            else
            {
                txtPapaya.Enabled = false;
                txtPapaya.Text = "0";
            }
        }

        private void chkAvocado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAvocado.Checked == true)
            {
                txtAvocado.Enabled = true;
                txtAvocado.Text = "";
                txtAvocado.Focus();
            }
            else
            {
                txtAvocado.Enabled = false;
                txtAvocado.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[22];
            itemcost[0] = Convert.ToDouble(txtFries.Text) * Price_Fries;
            itemcost[1] = Convert.ToDouble(txtSalad.Text) * Price_Salad;
            itemcost[2] = Convert.ToDouble(txtHamburger.Text) * Price_Hamburger;
            itemcost[3] = Convert.ToDouble(txtOnion.Text) * Price_Onion;
            itemcost[4] = Convert.ToDouble(txtChicken.Text) * Price_Chicken;
            itemcost[5] = Convert.ToDouble(txtFish.Text) * Price_Fish;
            itemcost[6] = Convert.ToDouble(txtCheese.Text) * Price_Cheese;
            itemcost[7] = Convert.ToDouble(txtChickensand.Text) * Price_Chickensand;
            itemcost[8] = Convert.ToDouble(txtHaloHalo.Text) * Price_Halohalo;
            itemcost[9] = Convert.ToDouble(txtLecheflan.Text) * Price_LecheFlan;
            itemcost[10] = Convert.ToDouble(txtUbehalaya.Text) * Price_Ubehalaya;
            itemcost[11] = Convert.ToDouble(txtSapinsapin.Text) * Price_Sapinsapin;
            itemcost[12] = Convert.ToDouble(txtMaisconyelo.Text) * Price_Maisconyelo;
            itemcost[13] = Convert.ToDouble(txtMountain.Text) * Price_Mountaindew;
            itemcost[14] = Convert.ToDouble(txtCoca.Text) * Price_CocaCola;
            itemcost[15] = Convert.ToDouble(txtRoyal.Text) * Price_Royal;
            itemcost[16] = Convert.ToDouble(txtSprite.Text) * Price_Sprite;
            itemcost[17] = Convert.ToDouble(txtBottle.Text) * Price_Bottle;
            itemcost[18] = Convert.ToDouble(txtGreen.Text) * Price_Green;
            itemcost[19] = Convert.ToDouble(txtMango.Text) * Price_Mango;
            itemcost[20] = Convert.ToDouble(txtPapaya.Text) * Price_Papaya;
            itemcost[21] = Convert.ToDouble(txtAvocado.Text) * Price_Avocado;

            double cost, ichange;

            if (cmbPaymentMethod.Text == "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5]
                 + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13]
                    + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19]
                    + itemcost[20] + itemcost[21];

                lblSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate)/100;
                lblTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lblTotal.Text = Convert.ToString(iTotal);

                ichange = Convert.ToDouble(txtPaymentmethod.Text);
                cost = ichange - (iTax + iTotal);
                lblChange.Text = Convert.ToString(cost);
                 
               
            }
            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                        itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13]
                        + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19]
                        + itemcost[20] + itemcost[21];

                lblSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lblTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lblTotal.Text = Convert.ToString(iTotal);

            }
        
        }







        public double Tax_rate { get; set; }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
