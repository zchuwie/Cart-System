namespace UCCFoodTrackerNeo
{
    partial class CartPage
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
            this.foodPanel = new System.Windows.Forms.Panel();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameCheckOut = new System.Windows.Forms.Label();
            this.foodOrderView = new System.Windows.Forms.Panel();
            this.printBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.foodPanel.SuspendLayout();
            this.checkoutPanel.SuspendLayout();
            this.cartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodPanel
            // 
            this.foodPanel.AutoScroll = true;
            this.foodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.foodPanel.Controls.Add(this.cartPanel);
            this.foodPanel.Controls.Add(this.checkoutPanel);
            this.foodPanel.Location = new System.Drawing.Point(47, 32);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(757, 457);
            this.foodPanel.TabIndex = 5;
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(106)))), ((int)(((byte)(51)))));
            this.checkoutPanel.Controls.Add(this.clearBtn);
            this.checkoutPanel.Controls.Add(this.printBtn);
            this.checkoutPanel.Controls.Add(this.foodOrderView);
            this.checkoutPanel.Controls.Add(this.userNameCheckOut);
            this.checkoutPanel.Controls.Add(this.label4);
            this.checkoutPanel.Controls.Add(this.label3);
            this.checkoutPanel.Controls.Add(this.label1);
            this.checkoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkoutPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.checkoutPanel.Location = new System.Drawing.Point(527, 0);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(230, 457);
            this.checkoutPanel.TabIndex = 0;
            // 
            // cartPanel
            // 
            this.cartPanel.AutoScroll = true;
            this.cartPanel.Controls.Add(this.label2);
            this.cartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartPanel.Location = new System.Drawing.Point(0, 0);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(527, 457);
            this.cartPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(230, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checkout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(106)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(527, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Orders:";
            // 
            // userNameCheckOut
            // 
            this.userNameCheckOut.AutoSize = true;
            this.userNameCheckOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameCheckOut.Location = new System.Drawing.Point(16, 73);
            this.userNameCheckOut.Name = "userNameCheckOut";
            this.userNameCheckOut.Size = new System.Drawing.Size(115, 17);
            this.userNameCheckOut.TabIndex = 4;
            this.userNameCheckOut.Text = "Neo Isaiah Nimo";
            // 
            // foodOrderView
            // 
            this.foodOrderView.AutoScroll = true;
            this.foodOrderView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(151)))), ((int)(((byte)(112)))));
            this.foodOrderView.Location = new System.Drawing.Point(19, 131);
            this.foodOrderView.Name = "foodOrderView";
            this.foodOrderView.Size = new System.Drawing.Size(189, 181);
            this.foodOrderView.TabIndex = 5;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(106)))), ((int)(((byte)(51)))));
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.printBtn.Location = new System.Drawing.Point(125, 390);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(83, 46);
            this.printBtn.TabIndex = 6;
            this.printBtn.Text = "PRINT";
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(106)))), ((int)(((byte)(51)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(244)))));
            this.clearBtn.Location = new System.Drawing.Point(19, 390);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(83, 46);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "CLEAR ORDERS";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(849, 520);
            this.ControlBox = false;
            this.Controls.Add(this.foodPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(849, 520);
            this.MinimumSize = new System.Drawing.Size(849, 520);
            this.Name = "CartPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.foodPanel.ResumeLayout(false);
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            this.cartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel foodPanel;
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel foodOrderView;
        private System.Windows.Forms.Label userNameCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}