namespace Control_de_ventas
{
    partial class frmControlVentas
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
            txtPr = new TextBox();
            txtpre = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            txtto = new TextBox();
            txtdes = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtsub = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Productos:";
            // 
            // txtPr
            // 
            txtPr.Location = new Point(105, 25);
            txtPr.Name = "txtPr";
            txtPr.Size = new Size(125, 27);
            txtPr.TabIndex = 1;
            // 
            // txtpre
            // 
            txtpre.Location = new Point(105, 58);
            txtpre.Name = "txtpre";
            txtpre.Size = new Size(125, 27);
            txtpre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 58);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "precio:";
            // 
            // button1
            // 
            button1.Location = new Point(40, 112);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(184, 112);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 276);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 9;
            label3.Text = "total:";
            // 
            // txtto
            // 
            txtto.Location = new Point(105, 276);
            txtto.Name = "txtto";
            txtto.Size = new Size(125, 27);
            txtto.TabIndex = 8;
            // 
            // txtdes
            // 
            txtdes.Location = new Point(117, 234);
            txtdes.Name = "txtdes";
            txtdes.Size = new Size(125, 27);
            txtdes.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 234);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "Descuento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 189);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 11;
            label5.Text = "subtotal:";
            // 
            // txtsub
            // 
            txtsub.Location = new Point(105, 182);
            txtsub.Name = "txtsub";
            txtsub.Size = new Size(125, 27);
            txtsub.TabIndex = 10;
            // 
            // frmControlVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 440);
            Controls.Add(label5);
            Controls.Add(txtsub);
            Controls.Add(label3);
            Controls.Add(txtto);
            Controls.Add(txtdes);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtpre);
            Controls.Add(txtPr);
            Controls.Add(label1);
            Name = "frmControlVentas";
            Text = "frmControlVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPr;
        private TextBox txtpre;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox txtto;
        private TextBox txtdes;
        private Label label4;
        private Label label5;
        private TextBox txtsub;
    }
}