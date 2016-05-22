using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Assignment2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            //reading from a file and load the data list.
            AlhaidData data;
            if (AlhaidData.load)
            {
                AlhaidData.load = false;
                try
                {
                    //reading from a file
                    FileStream infoFile = new FileStream("MyData/info.txt", FileMode.Open);
                    StreamReader infoLine = new StreamReader(infoFile);
                    string line;
                    line = infoLine.ReadLine();

                    while (line != null)
                    {
                        string[] lineArray = line.Split(',');
                        data = new AlhaidData(lineArray[0], lineArray[1], lineArray[2], lineArray[3]);
                        //also adding it to the static list for later uses
                        AlhaidData.dataList.Add(data);
                        line = infoLine.ReadLine();
                    }
                    infoLine.Close();
                }
                catch (IOException err)
                {
                    MessageBox.Show("Error: " + err.ToString());
                }
            }


            //loding the combo box
                for (int i = 0; i < AlhaidData.dataList.Count; i++)
            {
                comboBox.Items.Add(AlhaidData.dataList[i].Title);
            }
            
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the box
            richTextBox.Clear();

            //add some formating (ask why colors r not being changed)
            float fontSize = 15;    
            string fontFamily = "Times New Roman";
            richTextBox.Font = new Font(fontFamily, fontSize,FontStyle.Bold);
            Color[] bcolors = {Color.Aqua, Color.Coral, Color.Firebrick, Color.MediumPurple};
            Color[] fcolors = {Color.Blue, Color.Yellow, Color.SandyBrown, Color.Gold};
            Random random = new Random();
            int ranNum = random.Next(0, 3);
            richTextBox.SelectionBackColor = bcolors[ranNum]; 
            richTextBox.SelectionColor = fcolors[ranNum]; 
            
            //displaying info in the richbox
            richTextBox.AppendText(AlhaidData.dataList[comboBox.SelectedIndex].ToString());
            
        }

        private void butRating_Click(object sender, EventArgs e)
        {
            movies();
        }

        private void butGenre_Click(object sender, EventArgs e)
        {
            music();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            move();
        }

        private void groupMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movies();
        }

        private void classicMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            move();
        }

        private void groupMoviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            movies();
        }

        private void classicMusicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            music();
        }

        private void showAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            move();
        }

        //group movies by rating
        private void movies()
        {
            listBox.Items.Clear();
            var movies = from m in AlhaidData.dataList where m.MusOrMov == "Movie" orderby m.Rating descending select m; 
            foreach (var m in movies)
            {
                listBox.Items.Add(m.ToString());
            }
        }

        //show only classic music
        private void music()
        {
            listBox.Items.Clear();
            var music = from m in AlhaidData.dataList where m.MusOrMov == "Music" && m.Type == "Classical Music" select m;
            foreach (var m in music)
            {
                listBox.Items.Add(m.ToString());
            }
        }

        //show the 2nd form
        private void move()
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }






    }
}
