namespace WindowsFormsApp1.formularios.Inicial
{
    partial class fmnTelaPrincipal
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
            this.btnProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(24, 27);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(100, 28);
            this.btnProduto.TabIndex = 0;
            this.btnProduto.Text = "Lista de Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // fmnTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 139);
            this.Controls.Add(this.btnProduto);
            this.Name = "fmnTelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.fmnTelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduto;
    }
}