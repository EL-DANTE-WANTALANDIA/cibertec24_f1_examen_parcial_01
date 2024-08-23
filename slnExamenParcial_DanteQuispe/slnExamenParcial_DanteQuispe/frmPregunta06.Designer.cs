namespace slnExamenParcial_DanteQuispe
{
    partial class frmPregunta06
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
            lstBox1 = new ListBox();
            btn1 = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            SuspendLayout();
            // 
            // lstBox1
            // 
            lstBox1.FormattingEnabled = true;
            lstBox1.ItemHeight = 15;
            lstBox1.Location = new Point(12, 14);
            lstBox1.Name = "lstBox1";
            lstBox1.Size = new Size(205, 544);
            lstBox1.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(248, 253);
            btn1.Name = "btn1";
            btn1.Size = new Size(108, 31);
            btn1.TabIndex = 1;
            btn1.Text = "Generar Sueldos";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(417, 101);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "label1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(417, 186);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(38, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "label2";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(417, 314);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(38, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "label3";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(417, 396);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(38, 15);
            lbl4.TabIndex = 2;
            lbl4.Text = "label4";
            // 
            // frmPregunta06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 576);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btn1);
            Controls.Add(lstBox1);
            Name = "frmPregunta06";
            Text = "frmPregunta06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBox1;
        private Button btn1;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
    }
}