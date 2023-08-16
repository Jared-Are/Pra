namespace PromedioNotas
{
    partial class frmPromedioNotas
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
            btncalcular = new Button();
            btnnuevo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textnota1 = new TextBox();
            textnota2 = new TextBox();
            textnota3 = new TextBox();
            textestado = new TextBox();
            textpromedio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(26, 180);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(104, 48);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(149, 180);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(109, 48);
            btnnuevo.TabIndex = 1;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Nota 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Nota 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 129);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Nota 3:";
            // 
            // textnota1
            // 
            textnota1.Location = new Point(88, 21);
            textnota1.Name = "textnota1";
            textnota1.Size = new Size(125, 27);
            textnota1.TabIndex = 5;
            // 
            // textnota2
            // 
            textnota2.Location = new Point(88, 75);
            textnota2.Name = "textnota2";
            textnota2.Size = new Size(125, 27);
            textnota2.TabIndex = 6;
            // 
            // textnota3
            // 
            textnota3.Location = new Point(88, 122);
            textnota3.Name = "textnota3";
            textnota3.Size = new Size(125, 27);
            textnota3.TabIndex = 7;
            // 
            // textestado
            // 
            textestado.Location = new Point(109, 297);
            textestado.Name = "textestado";
            textestado.Size = new Size(125, 27);
            textestado.TabIndex = 11;
            // 
            // textpromedio
            // 
            textpromedio.Location = new Point(109, 250);
            textpromedio.Name = "textpromedio";
            textpromedio.Size = new Size(125, 27);
            textpromedio.TabIndex = 10;
            textpromedio.TextChanged += textpromedio_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 304);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 250);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 8;
            label4.Text = "Promedio:";
            // 
            // frmPromedioNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 433);
            Controls.Add(textestado);
            Controls.Add(textpromedio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textnota3);
            Controls.Add(textnota2);
            Controls.Add(textnota1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnnuevo);
            Controls.Add(btncalcular);
            Name = "frmPromedioNotas";
            Text = "frmPromedioNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Button btnnuevo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textnota1;
        private TextBox textnota2;
        private TextBox textnota3;
        private TextBox textestado;
        private TextBox textpromedio;
        private Label label5;
        private Label label4;
    }
}