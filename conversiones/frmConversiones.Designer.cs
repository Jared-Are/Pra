namespace conversiones
{
    partial class frmConversiones
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
            m = new Label();
            txtM = new TextBox();
            txtcm = new TextBox();
            label1 = new Label();
            txtPul = new TextBox();
            label3 = new Label();
            txtpi = new TextBox();
            label4 = new Label();
            txtya = new TextBox();
            label5 = new Label();
            btnConvertir = new Button();
            btnNuevo = new Button();
            SuspendLayout();
            // 
            // m
            // 
            m.AutoSize = true;
            m.Location = new Point(23, 54);
            m.Name = "m";
            m.Size = new Size(58, 20);
            m.TabIndex = 0;
            m.Text = "Metros:";
            // 
            // txtM
            // 
            txtM.Location = new Point(87, 47);
            txtM.Name = "txtM";
            txtM.Size = new Size(100, 27);
            txtM.TabIndex = 1;
            // 
            // txtcm
            // 
            txtcm.Location = new Point(119, 143);
            txtcm.Name = "txtcm";
            txtcm.Size = new Size(100, 27);
            txtcm.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 150);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 2;
            label1.Text = "centímetros:";
            // 
            // txtPul
            // 
            txtPul.Location = new Point(119, 188);
            txtPul.Name = "txtPul";
            txtPul.Size = new Size(100, 27);
            txtPul.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 191);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "pulgadas:";
            // 
            // txtpi
            // 
            txtpi.Location = new Point(119, 235);
            txtpi.Name = "txtpi";
            txtpi.Size = new Size(100, 27);
            txtpi.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 235);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "pies:";
            // 
            // txtya
            // 
            txtya.Location = new Point(119, 279);
            txtya.Name = "txtya";
            txtya.Size = new Size(100, 27);
            txtya.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 286);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Yardas:";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(33, 95);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 29);
            btnConvertir.TabIndex = 11;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(171, 95);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmConversiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 348);
            Controls.Add(btnNuevo);
            Controls.Add(btnConvertir);
            Controls.Add(txtya);
            Controls.Add(label5);
            Controls.Add(txtpi);
            Controls.Add(label4);
            Controls.Add(txtPul);
            Controls.Add(label3);
            Controls.Add(txtcm);
            Controls.Add(label1);
            Controls.Add(txtM);
            Controls.Add(m);
            Name = "frmConversiones";
            Text = "frmConversiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label m;
        private TextBox txtM;
        private TextBox txtcm;
        private Label label1;
        private TextBox txtPul;
        private Label label3;
        private TextBox txtpi;
        private Label label4;
        private TextBox txtya;
        private Label label5;
        private Button btnConvertir;
        private Button btnNuevo;
    }
}