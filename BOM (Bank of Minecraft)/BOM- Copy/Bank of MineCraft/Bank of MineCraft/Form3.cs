using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_of_MineCraft
{
    public partial class Form3 : Form
    {
        string Username, Address, PostalCd;
        double savings = 1000;
        double checking_one = 1000;
        double checking_two = 1000;
        double amount;
        double payee;
        int btnnheight = 23;
        public Form3(string x, string y, string z)
        {

            InitializeComponent();

            Username = x;
            Address = y;
            PostalCd = z;
            pnlChgInfo.Visible = false; 
            //Account display
            lblwelcuser.Text = Username;
            lbluser.Text = Username;
            lbladd.Text = Address;
            lblpst.Text = PostalCd;


            //parse int to string (for acounts)
            /* NVM this is useless should go in the actual btn transfer stuff
            lblCa1.Text = "$" + checking_one.ToString();
            lblCa2.Text = "$" + checking_two.ToString();
            lblSa.Text = "$" + savings.ToString();
            */

            //Recieve the textboxes amount input //AGAIN this goes in the btn transfer not here
            //double input = double.Parse(txtAmount.Text);    

         
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Sends user back to login form
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //Checking One = 0 || Checking Two = 1 || Savings = 2 || Payee = 3

            string Payee = txtPayee.Text;
            double input = double.Parse(txtAmount.Text);
   
            /////////////////////////////////////////////////////////
            ///
            //transfer from Checking One -> Checking Two
            if (cbfrom.SelectedIndex == 0 && cbto.SelectedIndex == 1)
            {
                checking_one = checking_one - input;
                checking_two = checking_two + input;

                lblCa1.Text = "$" + checking_one.ToString();
                lblCa2.Text = "$" + checking_two.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " from Checking Account One to Two.");
            }
            //transfer from Checking Two -> Checking One
            if (cbfrom.SelectedIndex == 1 && cbto.SelectedIndex == 0)
            {
                checking_one = checking_one + input;
                checking_two = checking_two - input;

                lblCa1.Text = "$" + checking_one.ToString();
                lblCa2.Text = "$" + checking_two.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " from Checking Account Two to One.");
            }
            ///
            /////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////
            ///
            //transfer from Checking One ->  Savings
            if (cbfrom.SelectedIndex == 0 && cbto.SelectedIndex == 2)
            {
                checking_one = checking_one - input;
                savings = savings + input;

                lblSa.Text = "$" + savings.ToString();
                lblCa1.Text = "$" + checking_one.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " from Checking Account One to Savings Account.");
            }
            //transfer from Savings ->  Checking One
            if (cbfrom.SelectedIndex == 2 && cbto.SelectedIndex == 0)
            {
                checking_one = checking_one + input;
                savings = savings - input;

                lblSa.Text = "$" + savings.ToString();
                lblCa1.Text = "$" + checking_one.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " from Savings Account to Checking Account One.");
            }
            ///
            /////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////
            ///
            //transfer from Checking Two ->  Savings Account
            if (cbfrom.SelectedIndex == 1 && cbto.SelectedIndex == 2)
            {
                checking_two = checking_two - input;
                savings = savings + input;

                lblSa.Text = "$" + savings.ToString();
                lblCa2.Text = "$" + checking_two.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " from Checking Account Two to Saving Account.");
            }
            //transfer from Savings Account ->  Checking Two
            if (cbfrom.SelectedIndex == 2 && cbto.SelectedIndex == 1)
            {
                checking_two = checking_two + input;
                savings = savings - input;

                lblSa.Text = "$" + savings.ToString();
                lblCa2.Text = "$" + checking_two.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " from Savings Account Two to Checking Account.");
            }
            ///
            /////////////////////////////////////////////////////////
 
            //transfer from Checking One -> Payee
            if (cbfrom.SelectedIndex == 0 && cbto.SelectedIndex == 3)
            {
              
                checking_one = checking_one - input;
                payee = payee + input;
                lblCa1.Text = "$" + checking_one.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " to " + Payee + ".");
            }

            //transfer from Checking Two -> Payee
            if (cbfrom.SelectedIndex == 1 && cbto.SelectedIndex == 3)
            {

                checking_two = checking_two - input;
                payee = payee + input;
                lblCa2.Text = "$" + checking_two.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " to " + Payee + ".");
            }

            //transfer from Savings -> Payee
            if (cbfrom.SelectedIndex == 2 && cbto.SelectedIndex == 3)
            {

                savings = savings - input;
                payee = payee + input;
                lblSa.Text = "$" + savings.ToString();
                MessageBox.Show("You have sucsessfully transfered $" + input + " to " + Payee + ".");
            }

            if (input > checking_one)
            {
                lblsec.Text = "MCSafeWeb Overdraft Status: Insecure"; lblsec.ForeColor = Color.Red;
            }
            else if (input > checking_two)
            {
                lblsec.Text = "MCSafeWeb Overdraft Status: Insecure"; lblsec.ForeColor = Color.Red;
            }
            else if (input > savings)
            {
                lblsec.Text = "MCSafeWeb Overdraft Status: Insecure"; lblsec.ForeColor = Color.Red;
            }
        }

        private void lblCa1_Click(object sender, EventArgs e)
        {
          
        }

        private void lblCa2_Click(object sender, EventArgs e)
        {

        }

        private void lblSa_Click(object sender, EventArgs e)
        {

        }

        private void lblwelcuser_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtPayee_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbto_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Else if statments to see if the selected index is equal to three, if so it will display
             the Payees label and its textbox. Also changes btn height looks pretier
             */

           
            if(cbto.SelectedIndex == 3)
            {
                btnTransfer.Height = 65;
                lblPayee.Visible = true;
                txtPayee.Visible = true;
            }
            else if (cbto.SelectedIndex == 1)
            {
                btnTransfer.Height = btnnheight;
                lblPayee.Visible = false;
                txtPayee.Visible = false;

            }
            else if (cbto.SelectedIndex == 2)
            {
                btnTransfer.Height = btnnheight;
                lblPayee.Visible = false;
                txtPayee.Visible = false;
            }

            
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //When the inital button for change is clicked, render the panel and disable the rest inputs.
            pnlChgInfo.Visible = true;
            btnTransfer.Enabled = false;
            cbfrom.Enabled = false;
            cbto.Enabled = false;
            txtAmount.Enabled = false;
            btnorder.Enabled = false;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click_2(object sender, EventArgs e)
        {

        }

        private void txtrename_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Change the text of the general information to the text box info and after 
             * set the panel nonvisable and button as disabled and re-enable the rest inputs.
            */
            lblwelcuser.Text = txtrename.Text;
            lbluser.Text = txtrename.Text;
            lbladd.Text = txtreaddy.Text;
            lblpst.Text = txtrepostal.Text;
            MessageBox.Show("All changes have been applied");
            pnlChgInfo.Visible = false;
            btnChange.Enabled = false;

            btnTransfer.Enabled = true;
            cbfrom.Enabled = true;
            cbto.Enabled = true;
            txtAmount.Enabled = true;
            btnorder.Enabled = true;
        }


        private void btnorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"From the Bank of Minecraft, your cheques have been order to " + lbladd.Text + " at" + lblpst.Text + ".");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
        

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
