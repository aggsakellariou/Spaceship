
namespace WindowsFormsApp102
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
            this.timerBulletS = new System.Windows.Forms.Timer(this.components);
            this.timerUfo = new System.Windows.Forms.Timer(this.components);
            this.timerBulletU = new System.Windows.Forms.Timer(this.components);
            this.timerSpaceshipLocation = new System.Windows.Forms.Timer(this.components);
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.ufo = new System.Windows.Forms.PictureBox();
            this.spaceship = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBulletS
            // 
            this.timerBulletS.Enabled = true;
            this.timerBulletS.Interval = 50;
            this.timerBulletS.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerUfo
            // 
            this.timerUfo.Enabled = true;
            this.timerUfo.Interval = 3000;
            this.timerUfo.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerBulletU
            // 
            this.timerBulletU.Enabled = true;
            this.timerBulletU.Interval = 85;
            this.timerBulletU.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timerSpaceshipLocation
            // 
            this.timerSpaceshipLocation.Enabled = true;
            this.timerSpaceshipLocation.Interval = 750;
            this.timerSpaceshipLocation.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timerSave
            // 
            this.timerSave.Enabled = true;
            this.timerSave.Interval = 20000;
            this.timerSave.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // ufo
            // 
            this.ufo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ufo.Image = global::WindowsFormsApp102.Properties.Resources.ufo_icon;
            this.ufo.Location = new System.Drawing.Point(464, 9);
            this.ufo.Margin = new System.Windows.Forms.Padding(0);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(80, 80);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ufo.TabIndex = 1;
            this.ufo.TabStop = false;
            this.ufo.Tag = "Enemy";
            // 
            // spaceship
            // 
            this.spaceship.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spaceship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.spaceship.Image = global::WindowsFormsApp102.Properties.Resources.spaceship_icon1;
            this.spaceship.Location = new System.Drawing.Point(459, 450);
            this.spaceship.Margin = new System.Windows.Forms.Padding(0);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(85, 85);
            this.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship.TabIndex = 0;
            this.spaceship.TabStop = false;
            this.spaceship.Tag = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.spaceship);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Location = new System.Drawing.Point(1000, 600);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerBulletS;
        private System.Windows.Forms.PictureBox spaceship;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer timerUfo;
        private System.Windows.Forms.Timer timerBulletU;
        private System.Windows.Forms.Timer timerSpaceshipLocation;
        private System.Windows.Forms.Timer timerSave;
    }
}

