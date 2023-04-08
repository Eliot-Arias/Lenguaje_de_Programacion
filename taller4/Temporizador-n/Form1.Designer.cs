namespace Temporizador_n
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
            components = new System.ComponentModel.Container();
            pBAvance = new ProgressBar();
            Lblprocesando = new Label();
            lblAvance = new Label();
            lblComentario = new Label();
            txtComentario = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pBAvance
            // 
            pBAvance.Location = new Point(12, 12);
            pBAvance.Maximum = 250;
            pBAvance.Name = "pBAvance";
            pBAvance.Size = new Size(776, 23);
            pBAvance.TabIndex = 0;
            // 
            // Lblprocesando
            // 
            Lblprocesando.AutoSize = true;
            Lblprocesando.Location = new Point(12, 38);
            Lblprocesando.Name = "Lblprocesando";
            Lblprocesando.Size = new Size(75, 15);
            Lblprocesando.TabIndex = 1;
            Lblprocesando.Text = "Procesando: ";
            // 
            // lblAvance
            // 
            lblAvance.AutoSize = true;
            lblAvance.Location = new Point(103, 38);
            lblAvance.Name = "lblAvance";
            lblAvance.Size = new Size(69, 15);
            lblAvance.TabIndex = 2;
            lblAvance.Text = "Procesando";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(12, 65);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(70, 15);
            lblComentario.TabIndex = 3;
            lblComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(12, 83);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(776, 355);
            txtComentario.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtComentario);
            Controls.Add(lblComentario);
            Controls.Add(lblAvance);
            Controls.Add(Lblprocesando);
            Controls.Add(pBAvance);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pBAvance;
        private Label Lblprocesando;
        private Label lblAvance;
        private Label lblComentario;
        private TextBox txtComentario;
        private System.Windows.Forms.Timer timer1;
    }
}