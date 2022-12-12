namespace Datumoraimunka12._12
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.szoveg = new System.Windows.Forms.TextBox();
            this.mentes = new System.Windows.Forms.Button();
            this.Megnyit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 284);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // szoveg
            // 
            this.szoveg.Location = new System.Drawing.Point(220, 52);
            this.szoveg.Name = "szoveg";
            this.szoveg.Size = new System.Drawing.Size(162, 22);
            this.szoveg.TabIndex = 2;
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(406, 51);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 23);
            this.mentes.TabIndex = 3;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // Megnyit
            // 
            this.Megnyit.Location = new System.Drawing.Point(406, 80);
            this.Megnyit.Name = "Megnyit";
            this.Megnyit.Size = new System.Drawing.Size(75, 23);
            this.Megnyit.TabIndex = 4;
            this.Megnyit.Text = "Megnyitás";
            this.Megnyit.UseVisualStyleBackColor = true;
            this.Megnyit.Click += new System.EventHandler(this.Megnyit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dátum";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Megnyit);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.szoveg);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox szoveg;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button Megnyit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

