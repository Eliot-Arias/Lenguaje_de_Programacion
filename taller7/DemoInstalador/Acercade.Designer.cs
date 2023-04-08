namespace DemoInstalador
{
    partial class Acercade
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
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblDesarrolladores = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Location = new System.Drawing.Point(152, 50);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(105, 13);
            this.lblNombreApp.TabIndex = 0;
            this.lblNombreApp.Text = "APLICACIÓN DEMO";
            // 
            // lblDesarrolladores
            // 
            this.lblDesarrolladores.AutoSize = true;
            this.lblDesarrolladores.Location = new System.Drawing.Point(177, 104);
            this.lblDesarrolladores.Name = "lblDesarrolladores";
            this.lblDesarrolladores.Size = new System.Drawing.Size(55, 13);
            this.lblDesarrolladores.TabIndex = 1;
            this.lblDesarrolladores.Text = "Elliot Arias";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(202, 168);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 2;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(202, 241);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(0, 13);
            this.LblFecha.TabIndex = 3;
            // 
            // Acercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 452);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDesarrolladores);
            this.Controls.Add(this.lblNombreApp);
            this.Name = "Acercade";
            this.Text = "Acercade";
            this.Load += new System.EventHandler(this.Acercade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Label lblDesarrolladores;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label LblFecha;
    }
}