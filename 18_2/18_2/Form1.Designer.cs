namespace _18_2
{
    partial class formMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNazv = new System.Windows.Forms.Label();
            this.rbFunt = new System.Windows.Forms.RadioButton();
            this.rbPud = new System.Windows.Forms.RadioButton();
            this.rbUnc = new System.Windows.Forms.RadioButton();
            this.rbDrahma = new System.Windows.Forms.RadioButton();
            this.rbGran = new System.Windows.Forms.RadioButton();
            this.lbl1Gr = new System.Windows.Forms.Label();
            this.lbl2Gr = new System.Windows.Forms.Label();
            this.lbl3Gr = new System.Windows.Forms.Label();
            this.lbl4Gr = new System.Windows.Forms.Label();
            this.lbl5Gr = new System.Windows.Forms.Label();
            this.lbl10Gr = new System.Windows.Forms.Label();
            this.lbl9Gr = new System.Windows.Forms.Label();
            this.lbl8Gr = new System.Windows.Forms.Label();
            this.lbl7Gr = new System.Windows.Forms.Label();
            this.lbl6Gr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbGran);
            this.panel1.Controls.Add(this.rbDrahma);
            this.panel1.Controls.Add(this.rbUnc);
            this.panel1.Controls.Add(this.rbPud);
            this.panel1.Controls.Add(this.rbFunt);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 120);
            this.panel1.TabIndex = 0;
            // 
            // lblNazv
            // 
            this.lblNazv.AutoSize = true;
            this.lblNazv.Location = new System.Drawing.Point(12, 9);
            this.lblNazv.Name = "lblNazv";
            this.lblNazv.Size = new System.Drawing.Size(109, 13);
            this.lblNazv.TabIndex = 1;
            this.lblNazv.Text = "Единица измерения";
            // 
            // rbFunt
            // 
            this.rbFunt.AutoSize = true;
            this.rbFunt.Checked = true;
            this.rbFunt.Location = new System.Drawing.Point(3, 3);
            this.rbFunt.Name = "rbFunt";
            this.rbFunt.Size = new System.Drawing.Size(60, 17);
            this.rbFunt.TabIndex = 0;
            this.rbFunt.TabStop = true;
            this.rbFunt.Text = "Фунты";
            this.rbFunt.UseVisualStyleBackColor = true;
            this.rbFunt.CheckedChanged += new System.EventHandler(this.rbFunt_CheckedChanged);
            // 
            // rbPud
            // 
            this.rbPud.AutoSize = true;
            this.rbPud.Location = new System.Drawing.Point(3, 26);
            this.rbPud.Name = "rbPud";
            this.rbPud.Size = new System.Drawing.Size(52, 17);
            this.rbPud.TabIndex = 1;
            this.rbPud.Text = "Пуды";
            this.rbPud.UseVisualStyleBackColor = true;
            this.rbPud.CheckedChanged += new System.EventHandler(this.rbFunt_CheckedChanged);
            // 
            // rbUnc
            // 
            this.rbUnc.AutoSize = true;
            this.rbUnc.Location = new System.Drawing.Point(3, 49);
            this.rbUnc.Name = "rbUnc";
            this.rbUnc.Size = new System.Drawing.Size(57, 17);
            this.rbUnc.TabIndex = 2;
            this.rbUnc.Text = "Унции";
            this.rbUnc.UseVisualStyleBackColor = true;
            this.rbUnc.CheckedChanged += new System.EventHandler(this.rbFunt_CheckedChanged);
            // 
            // rbDrahma
            // 
            this.rbDrahma.AutoSize = true;
            this.rbDrahma.Location = new System.Drawing.Point(3, 72);
            this.rbDrahma.Name = "rbDrahma";
            this.rbDrahma.Size = new System.Drawing.Size(67, 17);
            this.rbDrahma.TabIndex = 3;
            this.rbDrahma.Text = "Драхмы";
            this.rbDrahma.UseVisualStyleBackColor = true;
            this.rbDrahma.CheckedChanged += new System.EventHandler(this.rbFunt_CheckedChanged);
            // 
            // rbGran
            // 
            this.rbGran.AutoSize = true;
            this.rbGran.Location = new System.Drawing.Point(3, 95);
            this.rbGran.Name = "rbGran";
            this.rbGran.Size = new System.Drawing.Size(57, 17);
            this.rbGran.TabIndex = 4;
            this.rbGran.Text = "Граны";
            this.rbGran.UseVisualStyleBackColor = true;
            this.rbGran.CheckedChanged += new System.EventHandler(this.rbFunt_CheckedChanged);
            // 
            // lbl1Gr
            // 
            this.lbl1Gr.AutoSize = true;
            this.lbl1Gr.Location = new System.Drawing.Point(136, 25);
            this.lbl1Gr.Name = "lbl1Gr";
            this.lbl1Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl1Gr.TabIndex = 2;
            this.lbl1Gr.Text = " ";
            // 
            // lbl2Gr
            // 
            this.lbl2Gr.AutoSize = true;
            this.lbl2Gr.Location = new System.Drawing.Point(136, 51);
            this.lbl2Gr.Name = "lbl2Gr";
            this.lbl2Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl2Gr.TabIndex = 3;
            this.lbl2Gr.Text = " ";
            // 
            // lbl3Gr
            // 
            this.lbl3Gr.AutoSize = true;
            this.lbl3Gr.Location = new System.Drawing.Point(136, 74);
            this.lbl3Gr.Name = "lbl3Gr";
            this.lbl3Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl3Gr.TabIndex = 4;
            this.lbl3Gr.Text = " ";
            // 
            // lbl4Gr
            // 
            this.lbl4Gr.AutoSize = true;
            this.lbl4Gr.Location = new System.Drawing.Point(136, 97);
            this.lbl4Gr.Name = "lbl4Gr";
            this.lbl4Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl4Gr.TabIndex = 5;
            this.lbl4Gr.Text = " ";
            // 
            // lbl5Gr
            // 
            this.lbl5Gr.AutoSize = true;
            this.lbl5Gr.Location = new System.Drawing.Point(136, 120);
            this.lbl5Gr.Name = "lbl5Gr";
            this.lbl5Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl5Gr.TabIndex = 6;
            this.lbl5Gr.Text = " ";
            // 
            // lbl10Gr
            // 
            this.lbl10Gr.AutoSize = true;
            this.lbl10Gr.Location = new System.Drawing.Point(136, 238);
            this.lbl10Gr.Name = "lbl10Gr";
            this.lbl10Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl10Gr.TabIndex = 11;
            this.lbl10Gr.Text = " ";
            // 
            // lbl9Gr
            // 
            this.lbl9Gr.AutoSize = true;
            this.lbl9Gr.Location = new System.Drawing.Point(136, 215);
            this.lbl9Gr.Name = "lbl9Gr";
            this.lbl9Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl9Gr.TabIndex = 10;
            this.lbl9Gr.Text = " ";
            // 
            // lbl8Gr
            // 
            this.lbl8Gr.AutoSize = true;
            this.lbl8Gr.Location = new System.Drawing.Point(136, 192);
            this.lbl8Gr.Name = "lbl8Gr";
            this.lbl8Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl8Gr.TabIndex = 9;
            this.lbl8Gr.Text = " ";
            // 
            // lbl7Gr
            // 
            this.lbl7Gr.AutoSize = true;
            this.lbl7Gr.Location = new System.Drawing.Point(136, 169);
            this.lbl7Gr.Name = "lbl7Gr";
            this.lbl7Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl7Gr.TabIndex = 8;
            this.lbl7Gr.Text = " ";
            // 
            // lbl6Gr
            // 
            this.lbl6Gr.AutoSize = true;
            this.lbl6Gr.Location = new System.Drawing.Point(136, 143);
            this.lbl6Gr.Name = "lbl6Gr";
            this.lbl6Gr.Size = new System.Drawing.Size(10, 13);
            this.lbl6Gr.TabIndex = 7;
            this.lbl6Gr.Text = " ";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(393, 260);
            this.Controls.Add(this.lbl10Gr);
            this.Controls.Add(this.lbl9Gr);
            this.Controls.Add(this.lbl8Gr);
            this.Controls.Add(this.lbl7Gr);
            this.Controls.Add(this.lbl6Gr);
            this.Controls.Add(this.lbl5Gr);
            this.Controls.Add(this.lbl4Gr);
            this.Controls.Add(this.lbl3Gr);
            this.Controls.Add(this.lbl2Gr);
            this.Controls.Add(this.lbl1Gr);
            this.Controls.Add(this.lblNazv);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.Text = "Перерасчет значений";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbGran;
        private System.Windows.Forms.RadioButton rbDrahma;
        private System.Windows.Forms.RadioButton rbUnc;
        private System.Windows.Forms.RadioButton rbPud;
        private System.Windows.Forms.RadioButton rbFunt;
        private System.Windows.Forms.Label lblNazv;
        private System.Windows.Forms.Label lbl1Gr;
        private System.Windows.Forms.Label lbl2Gr;
        private System.Windows.Forms.Label lbl3Gr;
        private System.Windows.Forms.Label lbl4Gr;
        private System.Windows.Forms.Label lbl5Gr;
        private System.Windows.Forms.Label lbl10Gr;
        private System.Windows.Forms.Label lbl9Gr;
        private System.Windows.Forms.Label lbl8Gr;
        private System.Windows.Forms.Label lbl7Gr;
        private System.Windows.Forms.Label lbl6Gr;
    }
}

