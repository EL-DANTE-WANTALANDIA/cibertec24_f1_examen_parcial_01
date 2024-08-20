namespace slnExamenParcial_DanteQuispe
{
    partial class frmPregunta03
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
            lbl1 = new Label();
            txtBox1 = new TextBox();
            button1 = new Button();
            lbl2 = new Label();
            txtBox2 = new TextBox();
            lbl3 = new Label();
            txtBox3 = new TextBox();
            lbl4 = new Label();
            txtBox4 = new TextBox();
            lbl5 = new Label();
            txtBox5 = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(88, 83);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(119, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Unidades Adquiridas:";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(266, 80);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(120, 150);
            button1.Name = "button1";
            button1.Size = new Size(246, 34);
            button1.TabIndex = 2;
            button1.Text = "Calcular el Importe de la Compra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(53, 265);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(154, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Importe Total de la Compra:";
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(266, 262);
            txtBox2.Name = "txtBox2";
            txtBox2.ReadOnly = true;
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 4;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(53, 227);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(158, 15);
            lbl3.TabIndex = 3;
            lbl3.Text = "Importe Total del Descuento:";
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(266, 224);
            txtBox3.Name = "txtBox3";
            txtBox3.ReadOnly = true;
            txtBox3.Size = new Size(100, 23);
            txtBox3.TabIndex = 4;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(422, 83);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(88, 15);
            lbl4.TabIndex = 5;
            lbl4.Text = "Precio Unitario:";
            // 
            // txtBox4
            // 
            txtBox4.Location = new Point(513, 80);
            txtBox4.Name = "txtBox4";
            txtBox4.ReadOnly = true;
            txtBox4.Size = new Size(55, 23);
            txtBox4.TabIndex = 1;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(574, 83);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(66, 15);
            lbl5.TabIndex = 5;
            lbl5.Text = "Descuento:";
            lbl5.Click += lbl5_Click;
            // 
            // txtBox5
            // 
            txtBox5.Location = new Point(643, 80);
            txtBox5.Name = "txtBox5";
            txtBox5.ReadOnly = true;
            txtBox5.Size = new Size(55, 23);
            txtBox5.TabIndex = 1;
            // 
            // frmPregunta03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(button1);
            Controls.Add(txtBox5);
            Controls.Add(txtBox4);
            Controls.Add(txtBox1);
            Controls.Add(lbl1);
            Name = "frmPregunta03";
            Text = "frmPregunta03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtBox1;
        private Button button1;
        private Label lbl2;
        private TextBox txtBox2;
        private Label lbl3;
        private TextBox txtBox3;
        private Label lbl4;
        private TextBox txtBox4;
        private Label lbl5;
        private TextBox txtBox5;
    }
}