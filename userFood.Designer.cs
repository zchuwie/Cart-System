namespace UCCFoodTrackerNeo
{
    partial class userFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.foodInfo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.foodPicturelbl = new System.Windows.Forms.PictureBox();
            this.foodPricelbl = new System.Windows.Forms.Label();
            this.foodNamelbl = new System.Windows.Forms.Label();
            this.foodStallNamelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.foodInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicturelbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.foodInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 189);
            this.panel1.TabIndex = 0;
            // 
            // foodInfo
            // 
            this.foodInfo.Controls.Add(this.foodStallNamelbl);
            this.foodInfo.Controls.Add(this.foodNamelbl);
            this.foodInfo.Controls.Add(this.foodPricelbl);
            this.foodInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foodInfo.Location = new System.Drawing.Point(0, 132);
            this.foodInfo.Name = "foodInfo";
            this.foodInfo.Size = new System.Drawing.Size(177, 57);
            this.foodInfo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.foodPicturelbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 132);
            this.panel2.TabIndex = 1;
            // 
            // foodPicturelbl
            // 
            this.foodPicturelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodPicturelbl.Location = new System.Drawing.Point(0, 0);
            this.foodPicturelbl.Name = "foodPicturelbl";
            this.foodPicturelbl.Size = new System.Drawing.Size(177, 132);
            this.foodPicturelbl.TabIndex = 0;
            this.foodPicturelbl.TabStop = false;
            // 
            // foodPricelbl
            // 
            this.foodPricelbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.foodPricelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodPricelbl.Location = new System.Drawing.Point(0, 0);
            this.foodPricelbl.Name = "foodPricelbl";
            this.foodPricelbl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.foodPricelbl.Size = new System.Drawing.Size(55, 57);
            this.foodPricelbl.TabIndex = 0;
            this.foodPricelbl.Text = "50.00";
            this.foodPricelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // foodNamelbl
            // 
            this.foodNamelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNamelbl.Location = new System.Drawing.Point(58, 8);
            this.foodNamelbl.Name = "foodNamelbl";
            this.foodNamelbl.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.foodNamelbl.Size = new System.Drawing.Size(116, 20);
            this.foodNamelbl.TabIndex = 1;
            this.foodNamelbl.Text = "Pork Tonkatsu";
            this.foodNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // foodStallNamelbl
            // 
            this.foodStallNamelbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodStallNamelbl.Location = new System.Drawing.Point(61, 28);
            this.foodStallNamelbl.Name = "foodStallNamelbl";
            this.foodStallNamelbl.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.foodStallNamelbl.Size = new System.Drawing.Size(113, 16);
            this.foodStallNamelbl.TabIndex = 2;
            this.foodStallNamelbl.Text = "Dada\'s Kainan";
            this.foodStallNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userFood";
            this.Size = new System.Drawing.Size(177, 189);
            this.panel1.ResumeLayout(false);
            this.foodInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodPicturelbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel foodInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox foodPicturelbl;
        private System.Windows.Forms.Label foodStallNamelbl;
        private System.Windows.Forms.Label foodNamelbl;
        private System.Windows.Forms.Label foodPricelbl;
    }
}
