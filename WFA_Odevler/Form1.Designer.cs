namespace WFA_Odevler
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi4 = new System.Windows.Forms.TextBox();
            this.txtSayi5 = new System.Windows.Forms.TextBox();
            this.txtSayi6 = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi1.Location = new System.Drawing.Point(90, 78);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(80, 71);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.Text = "0";
            this.txtSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi2.Location = new System.Drawing.Point(176, 78);
            this.txtSayi2.Multiline = true;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(80, 71);
            this.txtSayi2.TabIndex = 1;
            this.txtSayi2.Text = "0";
            this.txtSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayi3
            // 
            this.txtSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi3.Location = new System.Drawing.Point(262, 78);
            this.txtSayi3.Multiline = true;
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(80, 71);
            this.txtSayi3.TabIndex = 2;
            this.txtSayi3.Text = "0";
            this.txtSayi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayi4
            // 
            this.txtSayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi4.Location = new System.Drawing.Point(348, 78);
            this.txtSayi4.Multiline = true;
            this.txtSayi4.Name = "txtSayi4";
            this.txtSayi4.Size = new System.Drawing.Size(80, 71);
            this.txtSayi4.TabIndex = 3;
            this.txtSayi4.Text = "0";
            this.txtSayi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayi5
            // 
            this.txtSayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi5.Location = new System.Drawing.Point(434, 78);
            this.txtSayi5.Multiline = true;
            this.txtSayi5.Name = "txtSayi5";
            this.txtSayi5.Size = new System.Drawing.Size(80, 71);
            this.txtSayi5.TabIndex = 4;
            this.txtSayi5.Text = "0";
            this.txtSayi5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayi6
            // 
            this.txtSayi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi6.Location = new System.Drawing.Point(520, 78);
            this.txtSayi6.Multiline = true;
            this.txtSayi6.Name = "txtSayi6";
            this.txtSayi6.Size = new System.Drawing.Size(80, 71);
            this.txtSayi6.TabIndex = 5;
            this.txtSayi6.Text = "0";
            this.txtSayi6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(90, 155);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(510, 38);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Çekilş Yap";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.MetroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 236);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtSayi6);
            this.Controls.Add(this.txtSayi5);
            this.Controls.Add(this.txtSayi4);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Sayısal Loto 6/49";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.TextBox txtSayi4;
        private System.Windows.Forms.TextBox txtSayi5;
        private System.Windows.Forms.TextBox txtSayi6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Timer timer1;
    }
}

