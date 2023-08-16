namespace Capital
{
    partial class frmCapital
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
            label1 = new Label();
            txtS1 = new TextBox();
            txtS2 = new TextBox();
            label2 = new Label();
            txtS3 = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            btnNuevo = new Button();
            txtp3 = new TextBox();
            label4 = new Label();
            txtp2 = new TextBox();
            label5 = new Label();
            txtp1 = new TextBox();
            label6 = new Label();
            txtTo = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Socio 1:";
            // 
            // txtS1
            // 
            txtS1.Location = new Point(111, 23);
            txtS1.Name = "txtS1";
            txtS1.Size = new Size(125, 27);
            txtS1.TabIndex = 1;
            // 
            // txtS2
            // 
            txtS2.Location = new Point(111, 75);
            txtS2.Name = "txtS2";
            txtS2.Size = new Size(125, 27);
            txtS2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 78);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Socio 2:";
            // 
            // txtS3
            // 
            txtS3.Location = new Point(111, 121);
            txtS3.Name = "txtS3";
            txtS3.Size = new Size(125, 27);
            txtS3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 124);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Socio 3:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(35, 175);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(175, 175);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtp3
            // 
            txtp3.Location = new Point(111, 381);
            txtp3.Name = "txtp3";
            txtp3.Size = new Size(125, 27);
            txtp3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 384);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "Socio 3:";
            // 
            // txtp2
            // 
            txtp2.Location = new Point(111, 335);
            txtp2.Name = "txtp2";
            txtp2.Size = new Size(125, 27);
            txtp2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 338);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "Socio 2:";
            // 
            // txtp1
            // 
            txtp1.Location = new Point(111, 283);
            txtp1.Name = "txtp1";
            txtp1.Size = new Size(125, 27);
            txtp1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 286);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 8;
            label6.Text = "Socio 1:";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(111, 222);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(125, 27);
            txtTo.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 225);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 14;
            label7.Text = "Total :";
            // 
            // frmCapital
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 413);
            Controls.Add(txtTo);
            Controls.Add(label7);
            Controls.Add(txtp3);
            Controls.Add(label4);
            Controls.Add(txtp2);
            Controls.Add(label5);
            Controls.Add(txtp1);
            Controls.Add(label6);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtS3);
            Controls.Add(label3);
            Controls.Add(txtS2);
            Controls.Add(label2);
            Controls.Add(txtS1);
            Controls.Add(label1);
            Name = "frmCapital";
            Text = "frmCapital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtS1;
        private TextBox txtS2;
        private Label label2;
        private TextBox txtS3;
        private Label label3;
        private Button btnCalcular;
        private Button btnNuevo;
        private TextBox txtp3;
        private Label label4;
        private TextBox txtp2;
        private Label label5;
        private TextBox txtp1;
        private Label label6;
        private TextBox txtTo;
        private Label label7;
    }
}