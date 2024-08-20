namespace slnExamenParcial_DanteQuispe
{
    partial class frmPregunta04
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
            button1 = new Button();
            txtBox1 = new TextBox();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            txtBox2 = new TextBox();
            txtBox3 = new TextBox();
            txtBox4 = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(74, 48);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(95, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Donación Anual:";
            // 
            // button1
            // 
            button1.Location = new Point(202, 95);
            button1.Name = "button1";
            button1.Size = new Size(145, 37);
            button1.TabIndex = 1;
            button1.Text = "Destinar Donación";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(202, 45);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(145, 23);
            txtBox1.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(449, 117);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(94, 15);
            lbl2.TabIndex = 0;
            lbl2.Text = "Centro de Salud:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(449, 164);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(110, 15);
            lbl3.TabIndex = 0;
            lbl3.Text = "Comedor de Niños:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(449, 214);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(38, 15);
            lbl4.TabIndex = 0;
            lbl4.Text = "Bolsa:";
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(592, 114);
            txtBox2.Name = "txtBox2";
            txtBox2.ReadOnly = true;
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 2;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(592, 161);
            txtBox3.Name = "txtBox3";
            txtBox3.ReadOnly = true;
            txtBox3.Size = new Size(100, 23);
            txtBox3.TabIndex = 2;
            // 
            // txtBox4
            // 
            txtBox4.Location = new Point(592, 211);
            txtBox4.Name = "txtBox4";
            txtBox4.ReadOnly = true;
            txtBox4.Size = new Size(100, 23);
            txtBox4.TabIndex = 2;
            // 
            // frmPregunta04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox4);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(button1);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "frmPregunta04";
            Text = "frmPregunta04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button button1;
        private TextBox txtBox1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private TextBox txtBox2;
        private TextBox txtBox3;
        private TextBox txtBox4;
    }
}