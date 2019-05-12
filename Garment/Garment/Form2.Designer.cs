namespace Garment
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SIDE = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ACCOUNT = new System.Windows.Forms.Button();
            this.ITEMS = new System.Windows.Forms.Button();
            this.PRODUCT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ABOUT = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.accountPicBox = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.home1 = new Garment.Home();
            this.info1 = new Garment.Info();
            this.productUC1 = new Garment.ProductUC();
            this.item1 = new Garment.Item();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SIDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.accountPicBox);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 44);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.ABOUT);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 704);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(822, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SIDE
            // 
            this.SIDE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.SIDE.Controls.Add(this.ACCOUNT);
            this.SIDE.Controls.Add(this.ITEMS);
            this.SIDE.Controls.Add(this.PRODUCT);
            this.SIDE.Controls.Add(this.button4);
            this.SIDE.Dock = System.Windows.Forms.DockStyle.Left;
            this.SIDE.Location = new System.Drawing.Point(49, 44);
            this.SIDE.Name = "SIDE";
            this.SIDE.Size = new System.Drawing.Size(197, 704);
            this.SIDE.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(822, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 44);
            this.button4.TabIndex = 38;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ACCOUNT
            // 
            this.ACCOUNT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ACCOUNT.FlatAppearance.BorderSize = 0;
            this.ACCOUNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACCOUNT.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCOUNT.ForeColor = System.Drawing.Color.Purple;
            this.ACCOUNT.Image = global::Garment.Properties.Resources.icons8_user_64__1_3;
            this.ACCOUNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ACCOUNT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ACCOUNT.Location = new System.Drawing.Point(6, 190);
            this.ACCOUNT.Name = "ACCOUNT";
            this.ACCOUNT.Size = new System.Drawing.Size(185, 57);
            this.ACCOUNT.TabIndex = 42;
            this.ACCOUNT.Text = "         Account        Info";
            this.ACCOUNT.UseVisualStyleBackColor = true;
            this.ACCOUNT.Click += new System.EventHandler(this.ACCOUNT_Click);
            // 
            // ITEMS
            // 
            this.ITEMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ITEMS.FlatAppearance.BorderSize = 0;
            this.ITEMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ITEMS.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITEMS.ForeColor = System.Drawing.Color.Purple;
            this.ITEMS.Image = global::Garment.Properties.Resources.icons8_trolley_642;
            this.ITEMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ITEMS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ITEMS.Location = new System.Drawing.Point(3, 133);
            this.ITEMS.Name = "ITEMS";
            this.ITEMS.Size = new System.Drawing.Size(188, 51);
            this.ITEMS.TabIndex = 41;
            this.ITEMS.Text = "     Items";
            this.ITEMS.UseVisualStyleBackColor = true;
            this.ITEMS.Click += new System.EventHandler(this.ITEMS_Click);
            // 
            // PRODUCT
            // 
            this.PRODUCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PRODUCT.FlatAppearance.BorderSize = 0;
            this.PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PRODUCT.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCT.ForeColor = System.Drawing.Color.Purple;
            this.PRODUCT.Image = global::Garment.Properties.Resources.icons8_box_64__3_3;
            this.PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PRODUCT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PRODUCT.Location = new System.Drawing.Point(6, 76);
            this.PRODUCT.Name = "PRODUCT";
            this.PRODUCT.Size = new System.Drawing.Size(185, 51);
            this.PRODUCT.TabIndex = 40;
            this.PRODUCT.Text = "      Products";
            this.PRODUCT.UseVisualStyleBackColor = true;
            this.PRODUCT.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Garment.Properties.Resources.icons8_shutdown_265;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(0, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 57);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Garment.Properties.Resources.icons8_exit_filled_352;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(0, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 50);
            this.button3.TabIndex = 42;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Garment.Properties.Resources.icons8_home_263;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 44);
            this.button7.TabIndex = 41;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ABOUT
            // 
            this.ABOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ABOUT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ABOUT.FlatAppearance.BorderSize = 0;
            this.ABOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABOUT.Image = global::Garment.Properties.Resources.icons8_user_324;
            this.ABOUT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ABOUT.Location = new System.Drawing.Point(0, 658);
            this.ABOUT.Name = "ABOUT";
            this.ABOUT.Size = new System.Drawing.Size(49, 46);
            this.ABOUT.TabIndex = 40;
            this.ABOUT.UseVisualStyleBackColor = true;
            this.ABOUT.Click += new System.EventHandler(this.ABOUT_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Garment.Properties.Resources.icons8_menu_267;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 44);
            this.button5.TabIndex = 42;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // accountPicBox
            // 
            this.accountPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.accountPicBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.accountPicBox.Location = new System.Drawing.Point(863, 0);
            this.accountPicBox.Name = "accountPicBox";
            this.accountPicBox.Size = new System.Drawing.Size(72, 44);
            this.accountPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accountPicBox.TabIndex = 7;
            this.accountPicBox.TabStop = false;
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Dock = System.Windows.Forms.DockStyle.Right;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::Garment.Properties.Resources.icons8_twitter_262;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(935, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 44);
            this.button10.TabIndex = 38;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Garment.Properties.Resources.icons8_facebook_302;
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(984, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 44);
            this.button9.TabIndex = 37;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(246, 44);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(787, 704);
            this.home1.TabIndex = 4;
            // 
            // info1
            // 
            this.info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info1.Location = new System.Drawing.Point(0, 0);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(1033, 748);
            this.info1.TabIndex = 5;
            // 
            // productUC1
            // 
            this.productUC1.BackColor = System.Drawing.Color.White;
            this.productUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productUC1.Location = new System.Drawing.Point(0, 0);
            this.productUC1.Name = "productUC1";
            this.productUC1.Size = new System.Drawing.Size(1033, 748);
            this.productUC1.TabIndex = 6;
            // 
            // item1
            // 
            this.item1.BackColor = System.Drawing.Color.White;
            this.item1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item1.Location = new System.Drawing.Point(0, 0);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(1033, 748);
            this.item1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 748);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.SIDE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.productUC1);
            this.Controls.Add(this.info1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Garment Management App";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Form2_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.SIDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SIDE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ABOUT;
        private System.Windows.Forms.Button PRODUCT;
        private System.Windows.Forms.Button ITEMS;
        private System.Windows.Forms.Button ACCOUNT;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.PictureBox accountPicBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private Home home1;
        private Info info1;
        private ProductUC productUC1;
        private Item item1;
    }
}