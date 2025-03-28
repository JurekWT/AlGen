using System.ComponentModel;

namespace AlGen
{
    partial class zad1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zad1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExZad1 = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textIter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTurn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOsob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textChrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.buttonExZad1);
            this.groupBox1.Controls.Add(this.textOutput);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textIter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textTurn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textOsob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textChrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 564);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zadanie 1";
            // 
            // buttonExZad1
            // 
            this.buttonExZad1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExZad1.Location = new System.Drawing.Point(380, 74);
            this.buttonExZad1.Name = "buttonExZad1";
            this.buttonExZad1.Size = new System.Drawing.Size(218, 33);
            this.buttonExZad1.TabIndex = 1;
            this.buttonExZad1.Text = "Wyjście";
            this.buttonExZad1.UseVisualStyleBackColor = true;
            this.buttonExZad1.Click += new System.EventHandler(this.buttonExZad1_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(6, 155);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput.Size = new System.Drawing.Size(606, 403);
            this.textOutput.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textIter
            // 
            this.textIter.Location = new System.Drawing.Point(293, 127);
            this.textIter.Name = "textIter";
            this.textIter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textIter.Size = new System.Drawing.Size(49, 22);
            this.textIter.TabIndex = 7;
            this.textIter.Text = "20";
            this.textIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textIter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIter_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ilość iteracji (min. 20):";
            // 
            // textTurn
            // 
            this.textTurn.Location = new System.Drawing.Point(293, 85);
            this.textTurn.Name = "textTurn";
            this.textTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textTurn.Size = new System.Drawing.Size(49, 22);
            this.textTurn.TabIndex = 5;
            this.textTurn.Text = "2";
            this.textTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTurn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTurn_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rozmiar turnieju (% osobników, 2-20%):";
            // 
            // textOsob
            // 
            this.textOsob.Location = new System.Drawing.Point(293, 18);
            this.textOsob.Name = "textOsob";
            this.textOsob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textOsob.Size = new System.Drawing.Size(49, 22);
            this.textOsob.TabIndex = 3;
            this.textOsob.Text = "9";
            this.textOsob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textOsob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOsob_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liczba osobników (nieparzysta, min. 9):";
            // 
            // textChrom
            // 
            this.textChrom.Location = new System.Drawing.Point(293, 51);
            this.textChrom.Name = "textChrom";
            this.textChrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textChrom.Size = new System.Drawing.Size(49, 22);
            this.textChrom.TabIndex = 1;
            this.textChrom.Text = "3";
            this.textChrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textChrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textChrom_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba chromosomów na parametr (min. 3):\r\n";
            // 
            // zad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::AlGen.Properties.Resources.genetic_algorithm2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 583);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "zad1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zadanie 1";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonExZad1;

        private System.Windows.Forms.TextBox textOutput;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textIter;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textTurn;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.TextBox textOsob;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textChrom;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}