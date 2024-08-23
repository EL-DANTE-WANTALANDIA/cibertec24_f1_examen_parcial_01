namespace slnExamenParcial_DanteQuispe
{
    partial class frmPregunta05
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
            cmbBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            txtBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cmbBox1
            // 
            cmbBox1.FormattingEnabled = true;
            cmbBox1.Location = new Point(252, 60);
            cmbBox1.Name = "cmbBox1";
            cmbBox1.Size = new Size(56, 23);
            cmbBox1.TabIndex = 0;
            cmbBox1.SelectedIndexChanged += cmbBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 63);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar Categoría:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 63);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Pensión:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 100);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Descuento:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 150);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 2;
            label4.Text = "Pensión Actual:";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(506, 60);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 3;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(506, 97);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 3;
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(506, 147);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(162, 23);
            txtBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(171, 183);
            button1.Name = "button1";
            button1.Size = new Size(137, 42);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 115);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 1;
            label5.Text = "Promedio:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(188, 113);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // frmPregunta05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(cmbBox1);
            Name = "frmPregunta05";
            Text = "frmPregunta05";
            Load += frmPregunta05_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private TextBox txtBox3;
        private Button button1;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}