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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_Min = new System.Windows.Forms.TextBox();
            this.tBox_Max = new System.Windows.Forms.TextBox();
            this.tBox_Ciel = new System.Windows.Forms.TextBox();
            this.tBox_Prob_Pluie = new System.Windows.Forms.TextBox();
            this.tBox_Quantite_Pluie = new System.Windows.Forms.TextBox();
            this.tBox_Vent = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.lb_prevision = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
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
            this.groupBox1.Controls.Add(this.tBox_Prob_Pluie);
            this.groupBox1.Controls.Add(this.tBox_Quantite_Pluie);
            this.groupBox1.Controls.Add(this.tBox_Vent);
            this.groupBox1.Controls.Add(this.btn_ajouter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une prévision";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(227, 297);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 27);
            this.dateTimePicker.TabIndex = 18;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Température maximal :";
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
            // tBox_Prob_Pluie
            // 
            this.tBox_Prob_Pluie.Location = new System.Drawing.Point(227, 160);
            this.tBox_Prob_Pluie.Name = "tBox_Prob_Pluie";
            this.tBox_Prob_Pluie.Size = new System.Drawing.Size(203, 27);
            this.tBox_Prob_Pluie.TabIndex = 7;
            // 
            // tBox_Quantite_Pluie
            // 
            this.tBox_Quantite_Pluie.Location = new System.Drawing.Point(227, 202);
            this.tBox_Quantite_Pluie.Name = "tBox_Quantite_Pluie";
            this.tBox_Quantite_Pluie.Size = new System.Drawing.Size(203, 27);
            this.tBox_Quantite_Pluie.TabIndex = 6;
            // 
            // tBox_Vent
            // 
            this.tBox_Vent.Location = new System.Drawing.Point(227, 245);
            this.tBox_Vent.Name = "tBox_Vent";
            this.tBox_Vent.Size = new System.Drawing.Size(203, 27);
            this.tBox_Vent.TabIndex = 5;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(227, 344);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(203, 29);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter cette prévision";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(454, 356);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(391, 29);
            this.btn_afficher.TabIndex = 1;
            this.btn_afficher.Text = "Afficher cette prévision";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // lb_prevision
            // 
            this.lb_prevision.FormattingEnabled = true;
            this.lb_prevision.ItemHeight = 20;
            this.lb_prevision.Location = new System.Drawing.Point(454, 22);
            this.lb_prevision.Name = "lb_prevision";
            this.lb_prevision.Size = new System.Drawing.Size(391, 324);
            this.lb_prevision.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 405);
            this.Controls.Add(this.lb_prevision);
            this.Controls.Add(this.btn_afficher);
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
        private TextBox tBox_Prob_Pluie;
        private TextBox tBox_Quantite_Pluie;
        private TextBox tBox_Vent;
        private Button btn_ajouter;
        private Button btn_afficher;
        private ListBox lb_prevision;
        private DateTimePicker dateTimePicker;
        private ErrorProvider errorProv;
    }
}