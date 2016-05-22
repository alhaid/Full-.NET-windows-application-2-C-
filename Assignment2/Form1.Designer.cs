namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.butRating = new System.Windows.Forms.Button();
            this.butGenre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTipMovies = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMusic = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipList = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classicMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupMoviesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classicMusicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name: Hamzah Shafeeq\r\nStudent Number: 991 284 213\r\nProgram: System Analys" +
    "t\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.Color.Brown;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(598, 217);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(455, 112);
            this.listBox.TabIndex = 1;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(61, 216);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(506, 117);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(61, 186);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(506, 24);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // butRating
            // 
            this.butRating.Location = new System.Drawing.Point(598, 186);
            this.butRating.Name = "butRating";
            this.butRating.Size = new System.Drawing.Size(232, 24);
            this.butRating.TabIndex = 4;
            this.butRating.Text = "Movies Grouped By Rating\r\n\r\n ";
            this.toolTipMovies.SetToolTip(this.butRating, "Moves grouped by rating (5 stars to 1)");
            this.butRating.UseVisualStyleBackColor = true;
            this.butRating.Click += new System.EventHandler(this.butRating_Click);
            // 
            // butGenre
            // 
            this.butGenre.Location = new System.Drawing.Point(836, 186);
            this.butGenre.Name = "butGenre";
            this.butGenre.Size = new System.Drawing.Size(217, 24);
            this.butGenre.TabIndex = 5;
            this.butGenre.Text = "Classic Music\r\n";
            this.toolTipMovies.SetToolTip(this.butGenre, "All classic Music");
            this.butGenre.UseVisualStyleBackColor = true;
            this.butGenre.Click += new System.EventHandler(this.butGenre_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "See All List";
            this.toolTipList.SetToolTip(this.button1, "See all the list of movies & music");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTipMovies
            // 
            this.toolTipMovies.Tag = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupMoviesToolStripMenuItem,
            this.classicMusicToolStripMenuItem,
            this.showAllToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // groupMoviesToolStripMenuItem
            // 
            this.groupMoviesToolStripMenuItem.Name = "groupMoviesToolStripMenuItem";
            this.groupMoviesToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.groupMoviesToolStripMenuItem.Text = "Group Movies";
            this.groupMoviesToolStripMenuItem.Click += new System.EventHandler(this.groupMoviesToolStripMenuItem_Click);
            // 
            // classicMusicToolStripMenuItem
            // 
            this.classicMusicToolStripMenuItem.Name = "classicMusicToolStripMenuItem";
            this.classicMusicToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.classicMusicToolStripMenuItem.Text = "Classic Music";
            this.classicMusicToolStripMenuItem.Click += new System.EventHandler(this.classicMusicToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupMoviesToolStripMenuItem1,
            this.classicMusicToolStripMenuItem1,
            this.showAllToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 110);
            this.contextMenuStrip1.Text = "Group Movies";
            // 
            // groupMoviesToolStripMenuItem1
            // 
            this.groupMoviesToolStripMenuItem1.Name = "groupMoviesToolStripMenuItem1";
            this.groupMoviesToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.groupMoviesToolStripMenuItem1.Text = "Group Movies";
            this.groupMoviesToolStripMenuItem1.Click += new System.EventHandler(this.groupMoviesToolStripMenuItem1_Click);
            // 
            // classicMusicToolStripMenuItem1
            // 
            this.classicMusicToolStripMenuItem1.Name = "classicMusicToolStripMenuItem1";
            this.classicMusicToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.classicMusicToolStripMenuItem1.Text = "Classic Music";
            this.classicMusicToolStripMenuItem1.Click += new System.EventHandler(this.classicMusicToolStripMenuItem1_Click);
            // 
            // showAllToolStripMenuItem1
            // 
            this.showAllToolStripMenuItem1.Name = "showAllToolStripMenuItem1";
            this.showAllToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.showAllToolStripMenuItem1.Text = "Show All";
            this.showAllToolStripMenuItem1.Click += new System.EventHandler(this.showAllToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 575);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butGenre);
            this.Controls.Add(this.butRating);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hamzah Shafeeq";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button butRating;
        private System.Windows.Forms.Button butGenre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTipMovies;
        private System.Windows.Forms.ToolTip toolTipList;
        private System.Windows.Forms.ToolTip toolTipMusic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classicMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem groupMoviesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classicMusicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem1;

    }
}

