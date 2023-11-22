namespace UCCFoodTrackerNeo
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.signoutBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.storesBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(74)))));
            this.panelMenu.Controls.Add(this.signoutBtn);
            this.panelMenu.Controls.Add(this.cartBtn);
            this.panelMenu.Controls.Add(this.storesBtn);
            this.panelMenu.Controls.Add(this.homeBtn);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(243, 593);
            this.panelMenu.TabIndex = 0;
            // 
            // signoutBtn
            // 
            this.signoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.signoutBtn.FlatAppearance.BorderSize = 0;
            this.signoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.signoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("signoutBtn.Image")));
            this.signoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signoutBtn.Location = new System.Drawing.Point(0, 541);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.signoutBtn.Size = new System.Drawing.Size(243, 52);
            this.signoutBtn.TabIndex = 4;
            this.signoutBtn.Tag = "Sign-Out";
            this.signoutBtn.Text = "       Sign-Out";
            this.signoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signoutBtn.UseVisualStyleBackColor = true;
            // 
            // cartBtn
            // 
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartBtn.FlatAppearance.BorderSize = 0;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.cartBtn.Image = ((System.Drawing.Image)(resources.GetObject("cartBtn.Image")));
            this.cartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartBtn.Location = new System.Drawing.Point(0, 236);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cartBtn.Size = new System.Drawing.Size(243, 52);
            this.cartBtn.TabIndex = 3;
            this.cartBtn.Tag = "Cart";
            this.cartBtn.Text = "       Your Cart";
            this.cartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // storesBtn
            // 
            this.storesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.storesBtn.FlatAppearance.BorderSize = 0;
            this.storesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storesBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.storesBtn.Image = ((System.Drawing.Image)(resources.GetObject("storesBtn.Image")));
            this.storesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storesBtn.Location = new System.Drawing.Point(0, 184);
            this.storesBtn.Name = "storesBtn";
            this.storesBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.storesBtn.Size = new System.Drawing.Size(243, 52);
            this.storesBtn.TabIndex = 2;
            this.storesBtn.Tag = "Stores";
            this.storesBtn.Text = "       Stores";
            this.storesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.storesBtn.UseVisualStyleBackColor = true;
            this.storesBtn.Click += new System.EventHandler(this.storesBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 132);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(243, 52);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Tag = "Home";
            this.homeBtn.Text = "       Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 132);
            this.panel1.TabIndex = 0;
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(192, 22);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(51, 50);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.Tag = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.panelTitleBar.Controls.Add(this.exitBtn);
            this.panelTitleBar.Controls.Add(this.labelTitleBar);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(243, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(706, 73);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.AutoSize = true;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.exitBtn.Location = new System.Drawing.Point(658, 22);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(36, 28);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelTitleBar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(106)))), ((int)(((byte)(51)))));
            this.labelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.labelTitleBar.Size = new System.Drawing.Size(301, 73);
            this.labelTitleBar.TabIndex = 0;
            this.labelTitleBar.Text = "Hello, userName!";
            this.labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitleBar_MouseDown);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(212)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(243, 73);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(706, 520);
            this.panelContent.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(949, 593);
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(949, 593);
            this.MinimumSize = new System.Drawing.Size(949, 593);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button signoutBtn;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Button storesBtn;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Button exitBtn;
    }
}

