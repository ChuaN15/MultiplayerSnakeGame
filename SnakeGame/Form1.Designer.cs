namespace SnakeGame
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
            this.pictureBox1a = new System.Windows.Forms.PictureBox();
            this.pictureBox2a = new System.Windows.Forms.PictureBox();
            this.pictureBox3a = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3a)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1a
            // 
            this.pictureBox1a.Location = new System.Drawing.Point(810, 40);
            this.pictureBox1a.Name = "pictureBox1a";
            this.pictureBox1a.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1a.TabIndex = 0;
            this.pictureBox1a.TabStop = false;
            // 
            // pictureBox2a
            // 
            this.pictureBox2a.Location = new System.Drawing.Point(452, 334);
            this.pictureBox2a.Name = "pictureBox2a";
            this.pictureBox2a.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2a.TabIndex = 1;
            this.pictureBox2a.TabStop = false;
            // 
            // pictureBox3a
            // 
            this.pictureBox3a.Location = new System.Drawing.Point(10, 40);
            this.pictureBox3a.Name = "pictureBox3a";
            this.pictureBox3a.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3a.TabIndex = 2;
            this.pictureBox3a.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("TeXGyreAdventor", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.selectPlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // selectPlayerToolStripMenuItem
            // 
            this.selectPlayerToolStripMenuItem.Name = "selectPlayerToolStripMenuItem";
            this.selectPlayerToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.selectPlayerToolStripMenuItem.Text = "Select Player";
            this.selectPlayerToolStripMenuItem.Click += new System.EventHandler(this.selectPlayerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3a);
            this.Controls.Add(this.pictureBox2a);
            this.Controls.Add(this.pictureBox1a);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("TeXGyreAdventor", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3a)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1a;
        private System.Windows.Forms.PictureBox pictureBox2a;
        private System.Windows.Forms.PictureBox pictureBox3a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPlayerToolStripMenuItem;
    }
}

