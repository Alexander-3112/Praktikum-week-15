namespace Praktikum_week_15
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
            this.radioButtonMakan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBMenu = new System.Windows.Forms.ComboBox();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelharga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonpanggilform = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMakan
            // 
            this.radioButtonMakan.AutoSize = true;
            this.radioButtonMakan.Location = new System.Drawing.Point(399, 71);
            this.radioButtonMakan.Name = "radioButtonMakan";
            this.radioButtonMakan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakan.TabIndex = 0;
            this.radioButtonMakan.TabStop = true;
            this.radioButtonMakan.Text = "Makanan";
            this.radioButtonMakan.UseVisualStyleBackColor = true;
            this.radioButtonMakan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(511, 71);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinuman.TabIndex = 1;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ITEMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu";
            // 
            // CBMenu
            // 
            this.CBMenu.FormattingEnabled = true;
            this.CBMenu.Location = new System.Drawing.Point(474, 110);
            this.CBMenu.Name = "CBMenu";
            this.CBMenu.Size = new System.Drawing.Size(121, 21);
            this.CBMenu.TabIndex = 4;
            this.CBMenu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(12, 71);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(209, 290);
            this.listBoxMenu.TabIndex = 5;
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.Location = new System.Drawing.Point(227, 71);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(120, 290);
            this.listBoxHarga.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga";
            // 
            // labelharga
            // 
            this.labelharga.AutoSize = true;
            this.labelharga.Location = new System.Drawing.Point(700, 110);
            this.labelharga.Name = "labelharga";
            this.labelharga.Size = new System.Drawing.Size(10, 13);
            this.labelharga.TabIndex = 8;
            this.labelharga.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(62, 52);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNormal.TabIndex = 10;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Location = new System.Drawing.Point(162, 52);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(56, 17);
            this.radioButtonJumbo.TabIndex = 11;
            this.radioButtonJumbo.TabStop = true;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            this.radioButtonJumbo.CheckedChanged += new System.EventHandler(this.radioButtonJumbo_CheckedChanged);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(461, 256);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 43);
            this.buttonBuy.TabIndex = 12;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonpanggilform
            // 
            this.buttonpanggilform.Location = new System.Drawing.Point(669, 338);
            this.buttonpanggilform.Name = "buttonpanggilform";
            this.buttonpanggilform.Size = new System.Drawing.Size(75, 41);
            this.buttonpanggilform.TabIndex = 13;
            this.buttonpanggilform.Text = "Check out";
            this.buttonpanggilform.UseVisualStyleBackColor = true;
            this.buttonpanggilform.Click += new System.EventHandler(this.buttonpanggilform_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bu Dewi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonJumbo);
            this.panel1.Controls.Add(this.radioButtonNormal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(399, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 72);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(256, 397);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonpanggilform);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelharga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.CBMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonMinuman);
            this.Controls.Add(this.radioButtonMakan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMakan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBMenu;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelharga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonpanggilform;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
    }
}

