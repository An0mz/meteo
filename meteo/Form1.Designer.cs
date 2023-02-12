namespace meteo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Prevision = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tBox_Prop_Pluie = new System.Windows.Forms.TextBox();
            this.tBox_Quantité_Pluie = new System.Windows.Forms.TextBox();
            this.tBox_Min = new System.Windows.Forms.TextBox();
            this.tBox_Max = new System.Windows.Forms.TextBox();
            this.tBox_Ciel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBox_Min);
            this.groupBox1.Controls.Add(this.tBox_Max);
            this.groupBox1.Controls.Add(this.tBox_Ciel);
            this.groupBox1.Controls.Add(this.tBox_Prop_Pluie);
            this.groupBox1.Controls.Add(this.tBox_Quantité_Pluie);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une prévision";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher cette prévision";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox_Prevision
            // 
            this.listBox_Prevision.FormattingEnabled = true;
            this.listBox_Prevision.ItemHeight = 20;
            this.listBox_Prevision.Location = new System.Drawing.Point(454, 22);
            this.listBox_Prevision.Name = "listBox_Prevision";
            this.listBox_Prevision.Size = new System.Drawing.Size(391, 324);
            this.listBox_Prevision.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ajouter cette prévision";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 27);
            this.textBox2.TabIndex = 5;
            // 
            // tBox_Prop_Pluie
            // 
            this.tBox_Prop_Pluie.Location = new System.Drawing.Point(227, 160);
            this.tBox_Prop_Pluie.Name = "tBox_Prop_Pluie";
            this.tBox_Prop_Pluie.Size = new System.Drawing.Size(203, 27);
            this.tBox_Prop_Pluie.TabIndex = 7;
            // 
            // tBox_Quantité_Pluie
            // 
            this.tBox_Quantité_Pluie.Location = new System.Drawing.Point(227, 202);
            this.tBox_Quantité_Pluie.Name = "tBox_Quantité_Pluie";
            this.tBox_Quantité_Pluie.Size = new System.Drawing.Size(203, 27);
            this.tBox_Quantité_Pluie.TabIndex = 6;
            // 
            // tBox_Min
            // 
            this.tBox_Min.Location = new System.Drawing.Point(227, 32);
            this.tBox_Min.Name = "tBox_Min";
            this.tBox_Min.Size = new System.Drawing.Size(203, 27);
            this.tBox_Min.TabIndex = 10;
            // 
            // tBox_Max
            // 
            this.tBox_Max.Location = new System.Drawing.Point(227, 74);
            this.tBox_Max.Name = "tBox_Max";
            this.tBox_Max.Size = new System.Drawing.Size(203, 27);
            this.tBox_Max.TabIndex = 9;
            // 
            // tBox_Ciel
            // 
            this.tBox_Ciel.Location = new System.Drawing.Point(227, 117);
            this.tBox_Ciel.Name = "tBox_Ciel";
            this.tBox_Ciel.Size = new System.Drawing.Size(203, 27);
            this.tBox_Ciel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Température minimale :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Température maximal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Probabilité de pluie : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ciel :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vitesse du vent (Km/h) : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantité de pluie (mm) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 27);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 405);
            this.Controls.Add(this.listBox_Prevision);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Prévision Météo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox tBox_Min;
        private TextBox tBox_Max;
        private TextBox tBox_Ciel;
        private TextBox tBox_Prop_Pluie;
        private TextBox tBox_Quantité_Pluie;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private ListBox listBox_Prevision;
        private DateTimePicker dateTimePicker1;
    }
}