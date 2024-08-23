namespace slnExamenParcial_DanteQuispe
{
    partial class frmPregunta02
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
            lbl2 = new Label();
            txtBox2 = new TextBox();
            button1 = new Button();
            lbl3 = new Label();
            lbl4 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(63, 64);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(138, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Monto total de compras:";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(232, 61);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(63, 190);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(77, 15);
            lbl2.TabIndex = 0;
            lbl2.Text = "Total a pagar:";
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(232, 187);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(209, 118);
            button1.Name = "button1";
            button1.Size = new Size(158, 36);
            button1.TabIndex = 2;
            button1.Text = "Calcular el Monto a Pagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(419, 61);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(66, 15);
            lbl3.TabIndex = 0;
            lbl3.Text = "Descuento:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(537, 61);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(28, 15);
            lbl4.TabIndex = 0;
            lbl4.Text = "IGV:";
            // 
            // frmPregunta02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lbl3);
            Controls.Add(lbl4);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "frmPregunta02";
            Text = "frmPregunta02";
            Load += frmPregunta02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtBox1;
        private Label lbl2;
        private TextBox txtBox2;
        private Button button1;
        private Label lbl3;
        private Label lbl4;
    }
}