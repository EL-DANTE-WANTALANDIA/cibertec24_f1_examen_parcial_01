namespace slnExamenParcial_DanteQuispe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            pregunta01ToolStripMenuItem = new ToolStripMenuItem();
            pregunta02ToolStripMenuItem = new ToolStripMenuItem();
            pregunta03ToolStripMenuItem = new ToolStripMenuItem();
            pregunta04ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pregunta01ToolStripMenuItem, pregunta02ToolStripMenuItem, pregunta03ToolStripMenuItem, pregunta04ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pregunta01ToolStripMenuItem
            // 
            pregunta01ToolStripMenuItem.Name = "pregunta01ToolStripMenuItem";
            pregunta01ToolStripMenuItem.Size = new Size(79, 20);
            pregunta01ToolStripMenuItem.Text = "Pregunta01";
            pregunta01ToolStripMenuItem.Click += pregunta01ToolStripMenuItem_Click;
            // 
            // pregunta02ToolStripMenuItem
            // 
            pregunta02ToolStripMenuItem.Name = "pregunta02ToolStripMenuItem";
            pregunta02ToolStripMenuItem.Size = new Size(79, 20);
            pregunta02ToolStripMenuItem.Text = "Pregunta02";
            pregunta02ToolStripMenuItem.Click += pregunta02ToolStripMenuItem_Click;
            // 
            // pregunta03ToolStripMenuItem
            // 
            pregunta03ToolStripMenuItem.Name = "pregunta03ToolStripMenuItem";
            pregunta03ToolStripMenuItem.Size = new Size(79, 20);
            pregunta03ToolStripMenuItem.Text = "Pregunta03";
            pregunta03ToolStripMenuItem.Click += pregunta03ToolStripMenuItem_Click;
            // 
            // pregunta04ToolStripMenuItem
            // 
            pregunta04ToolStripMenuItem.Name = "pregunta04ToolStripMenuItem";
            pregunta04ToolStripMenuItem.Size = new Size(79, 20);
            pregunta04ToolStripMenuItem.Text = "Pregunta04";
            pregunta04ToolStripMenuItem.Click += pregunta04ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Examen Parcial 01 Dante Quispe";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pregunta01ToolStripMenuItem;
        private ToolStripMenuItem pregunta02ToolStripMenuItem;
        private ToolStripMenuItem pregunta03ToolStripMenuItem;
        private ToolStripMenuItem pregunta04ToolStripMenuItem;
    }
}
