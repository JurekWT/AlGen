using System.ComponentModel;

namespace AlGen
{
    partial class Zad2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zad2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.textCompetition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSpecimen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIterate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textChromosom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.textOutput);
            this.panel1.Controls.Add(this.textCompetition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textSpecimen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textIterate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textChromosom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 607);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(357, 90);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(235, 51);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(357, 18);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(235, 51);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(5, 184);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput.Size = new System.Drawing.Size(608, 422);
            this.textOutput.TabIndex = 8;
            // 
            // textCompetition
            // 
            this.textCompetition.Enabled = false;
            this.textCompetition.Location = new System.Drawing.Point(284, 138);
            this.textCompetition.Name = "textCompetition";
            this.textCompetition.ReadOnly = true;
            this.textCompetition.Size = new System.Drawing.Size(33, 22);
            this.textCompetition.TabIndex = 7;
            this.textCompetition.Text = "3";
            this.textCompetition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rozmiar turnieju:";
            // 
            // textSpecimen
            // 
            this.textSpecimen.Enabled = false;
            this.textSpecimen.Location = new System.Drawing.Point(284, 98);
            this.textSpecimen.Name = "textSpecimen";
            this.textSpecimen.ReadOnly = true;
            this.textSpecimen.Size = new System.Drawing.Size(33, 22);
            this.textSpecimen.TabIndex = 5;
            this.textSpecimen.Text = "13";
            this.textSpecimen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liczba osobników:";
            // 
            // textIterate
            // 
            this.textIterate.Location = new System.Drawing.Point(284, 58);
            this.textIterate.Name = "textIterate";
            this.textIterate.Size = new System.Drawing.Size(33, 22);
            this.textIterate.TabIndex = 3;
            this.textIterate.Text = "100";
            this.textIterate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textIterate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIterate_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liczba iteracji (min.100):";
            // 
            // textChromosom
            // 
            this.textChromosom.Location = new System.Drawing.Point(284, 18);
            this.textChromosom.Name = "textChromosom";
            this.textChromosom.Size = new System.Drawing.Size(33, 22);
            this.textChromosom.TabIndex = 1;
            this.textChromosom.Text = "4";
            this.textChromosom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textChromosom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textChromosom_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba chromosomów na parametr (min.4):";
            // 
            // Zad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AlGen.Properties.Resources.genetic_algorithm2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 631);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zad2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zadanie 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.TextBox textOutput;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCompetition;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSpecimen;

        private System.Windows.Forms.TextBox textIterate;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textChromosom;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}