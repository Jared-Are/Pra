namespace Tienda_de_abarrotes
{
    partial class frmTienda
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
            txtCan = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            brnNuevo = new Button();
            txtTo = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Precio:";
            // 
            // txtPr
            // 
            txtPr.Location = new Point(124, 34);
            txtPr.Name = "txtPr";
            txtPr.Size = new Size(125, 27);
            txtPr.TabIndex = 1;
            // 
            // txtCan
            // 
            txtCan.Location = new Point(124, 84);
            txtCan.Name = "txtCan";
            txtCan.Size = new Size(125, 27);
            txtCan.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 84);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(30, 140);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // brnNuevo
            // 
            brnNuevo.Location = new Point(155, 140);
            brnNuevo.Name = "brnNuevo";
            brnNuevo.Size = new Size(94, 29);
            brnNuevo.TabIndex = 5;
            brnNuevo.Text = "Nuevo";
            brnNuevo.UseVisualStyleBackColor = true;
            brnNuevo.Click += brnNuevo_Click;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(124, 215);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(125, 27);
            txtTo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 215);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "Total:";
            // 
            // frmTienda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 374);
            Controls.Add(txtTo);
            Controls.Add(label3);
            Controls.Add(brnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtCan);
            Controls.Add(label2);
            Controls.Add(txtPr);
            Controls.Add(label1);
            Name = "frmTienda";
            Text = "frmTienda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPr;
        private TextBox txtCan;
        private Label label2;
        private Button btnCalcular;
        private Button brnNuevo;
        private TextBox txtTo;
        private Label label3;
    }
}