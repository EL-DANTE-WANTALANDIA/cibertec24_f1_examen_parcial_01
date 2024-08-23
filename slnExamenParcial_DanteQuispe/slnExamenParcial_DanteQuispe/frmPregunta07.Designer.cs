namespace slnExamenParcial_DanteQuispe
{
    partial class frmPregunta07
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
            txtBox1 = new TextBox();
            btn1 = new Button();
            lstBox1 = new ListBox();
            lbl1 = new Label();
            lbl2 = new Label();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(289, 53);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(54, 23);
            txtBox1.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(132, 116);
            btn1.Name = "btn1";
            btn1.Size = new Size(120, 43);
            btn1.TabIndex = 1;
            btn1.Text = "Generar Serie";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lstBox1
            // 
            lstBox1.FormattingEnabled = true;
            lstBox1.ItemHeight = 15;
            lstBox1.Location = new Point(436, 53);
            lstBox1.Name = "lstBox1";
            lstBox1.Size = new Size(129, 349);
            lstBox1.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(54, 56);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(229, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "Ingrese el tamaño de la serie de Fibonacci:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(54, 214);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(0, 15);
            lbl2.TabIndex = 4;
            // 
            // frmPregunta07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lstBox1);
            Controls.Add(btn1);
            Controls.Add(txtBox1);
            Name = "frmPregunta07";
            Text = "frmPregunta07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox1;
        private Button btn1;
        private ListBox lstBox1;
        private Label lbl1;
        private Label lbl2;
    }
}