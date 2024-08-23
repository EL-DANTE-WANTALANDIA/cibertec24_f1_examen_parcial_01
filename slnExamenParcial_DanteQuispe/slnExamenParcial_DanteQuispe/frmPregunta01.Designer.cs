namespace slnExamenParcial_DanteQuispe
{
    partial class frmPregunta01
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
            txtBox2 = new TextBox();
            lbl2 = new Label();
            txtBox3 = new TextBox();
            lbl3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(69, 54);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(136, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Total de horas dormidas:";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(213, 51);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 1;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(213, 97);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(69, 100);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(138, 15);
            lbl2.TabIndex = 0;
            lbl2.Text = "Total de horas en reposo:";
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(213, 160);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(100, 23);
            txtBox3.TabIndex = 3;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(44, 163);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(161, 15);
            lbl3.TabIndex = 0;
            lbl3.Text = "Total de calorías consumidas:";
            // 
            // button1
            // 
            button1.Location = new Point(176, 126);
            button1.Name = "button1";
            button1.Size = new Size(187, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular consumo de calorías";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPregunta1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "frmPregunta1";
            Text = "frmPregunta1";
            Load += frmPregunta01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private Label lbl2;
        private TextBox txtBox3;
        private Label lbl3;
        private Button button1;
    }
}