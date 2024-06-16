using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int ofBody, ofHead;
        string name; 

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void selectCharacter()
        {
            name = txtName.Text;
            groupBox1.Text = "Contestant: " + name;
            if (cbhead.SelectedIndex == 0)
            {
                pbHead.BackgroundImage = Resources.Head1; 
                ofHead = 0;
            }
            else if (cbhead.SelectedIndex == 1)
            {
                pbHead.BackgroundImage = Resources.Head2;
                ofHead = 1; 
            }
            else if (cbhead.SelectedIndex == 2)
            {
                pbHead.BackgroundImage = Resources.Head3;
                ofHead = 2;
            }
            else if (cbhead.SelectedIndex == 3)
            {
                pbHead.BackgroundImageLayout = ImageLayout.Stretch;
                pbHead.BackgroundImage = Resources.Head4;
                ofHead = 3;
            }
            else if (cbhead.SelectedIndex == 4)
            {
                pbHead.BackgroundImageLayout = ImageLayout.Stretch;
                pbHead.BackgroundImage = Resources.Head5;
                  ofHead = 4;
            }
            else if (cbhead.SelectedIndex == 5)
            {
                pbHead.BackgroundImageLayout = ImageLayout.Stretch;
                pbHead.BackgroundImage = Resources.Head6;
                   ofHead = 5;
            }

            else
            {
                pbHead.BackgroundImageLayout = ImageLayout.Zoom;
            }
            //

            if (cbbody.SelectedIndex == 0)
            {
                pbBody.BackgroundImage = Resources.Body1;
                ofBody = 0; 
            }
            else if (cbbody.SelectedIndex == 1)
            {
                pbBody.BackgroundImage = Resources.Body2;
                ofBody = 1;
            }
            else if (cbbody.SelectedIndex == 2)
            {
                pbBody.BackgroundImage = Resources.Body3;
                ofBody = 2;
            }

            else if (cbbody.SelectedIndex == 3)
            {
                pbBody.BackgroundImage = Resources.Body4;
                ofBody = 3;
            }
            else if (cbbody.SelectedIndex == 4)
            {
                pbBody.BackgroundImage = Resources.Body5;
                   ofBody = 4;
            }
            else if (cbbody.SelectedIndex == 5)
            {
                pbBody.BackgroundImage = Resources.Body6;
                ofBody = 5;
            }

          
        }


        private void cbhead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVis_Click(object sender, EventArgs e)
        {
          
            Form stage = new Form3(ofBody, ofHead, name);
            stage.Show();
            this.Hide();
 

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectCharacter(); 


            if (cbbody.SelectedIndex == -1 || cbbody.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please select your character or enter your name");
            }
            else
            {
                btnVis.Visible = true;
            }

        }
    }
}
