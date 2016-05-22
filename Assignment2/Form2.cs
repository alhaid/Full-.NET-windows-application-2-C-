using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBoxForm2.Items.Clear(); 
            for (int i = 0; i < AlhaidData.dataList.Count; i++)  //I can do this using data source instead of the loop
            {
                //display the info
                listBoxForm2.Items.Add(AlhaidData.dataList[i].ToString());
                //adding some formating
                float fontSize = 15;
                string fontFamily = "Times New Roman";
                listBoxForm2.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
                Color[] bcolors = { Color.Aqua, Color.Coral, Color.Firebrick, Color.MediumPurple };
                Color[] fcolors = { Color.Blue, Color.Yellow, Color.SandyBrown, Color.Gold };
                Random random = new Random();
                int ranNum = random.Next(0, 4);
                listBoxForm2.BackColor = bcolors[ranNum];
                listBoxForm2.ForeColor = fcolors[ranNum];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBoxForm2.Items.Clear(); 
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

    }
}
