
namespace WinFormAdatbazis
{
    partial class MainForm
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
            this.listBoxOrszagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFovaros = new System.Windows.Forms.TextBox();
            this.tbTerulet = new System.Windows.Forms.TextBox();
            this.tbAllamforma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOrszagok
            // 
            this.listBoxOrszagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxOrszagok.FormattingEnabled = true;
            this.listBoxOrszagok.Location = new System.Drawing.Point(0, 0);
            this.listBoxOrszagok.Name = "listBoxOrszagok";
            this.listBoxOrszagok.Size = new System.Drawing.Size(221, 450);
            this.listBoxOrszagok.TabIndex = 0;
            this.listBoxOrszagok.SelectedIndexChanged += new System.EventHandler(this.listBoxOrszagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAllamforma);
            this.groupBox1.Controls.Add(this.tbTerulet);
            this.groupBox1.Controls.Add(this.tbFovaros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(221, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A kiválasztott ország adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Főváros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terület";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Államforma";
            // 
            // tbFovaros
            // 
            this.tbFovaros.Location = new System.Drawing.Point(128, 80);
            this.tbFovaros.Name = "tbFovaros";
            this.tbFovaros.Size = new System.Drawing.Size(175, 20);
            this.tbFovaros.TabIndex = 4;
            // 
            // tbTerulet
            // 
            this.tbTerulet.Location = new System.Drawing.Point(128, 116);
            this.tbTerulet.Name = "tbTerulet";
            this.tbTerulet.Size = new System.Drawing.Size(175, 20);
            this.tbTerulet.TabIndex = 5;
            // 
            // tbAllamforma
            // 
            this.tbAllamforma.Location = new System.Drawing.Point(128, 152);
            this.tbAllamforma.Name = "tbAllamforma";
            this.tbAllamforma.Size = new System.Drawing.Size(175, 20);
            this.tbAllamforma.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(128, 44);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(175, 20);
            this.tbId.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxOrszagok);
            this.Name = "MainForm";
            this.Text = "Országok";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrszagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAllamforma;
        private System.Windows.Forms.TextBox tbTerulet;
        private System.Windows.Forms.TextBox tbFovaros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
    }
}

