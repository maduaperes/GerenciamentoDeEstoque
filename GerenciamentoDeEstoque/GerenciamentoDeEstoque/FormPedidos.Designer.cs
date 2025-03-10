namespace GerenciamentoDeEstoque
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ProdutosLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(787, 420);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.ProdutosLabel);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-1, -2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(787, 51);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // ProdutosLabel
            // 
            this.ProdutosLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProdutosLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdutosLabel.ForeColor = System.Drawing.Color.Black;
            this.ProdutosLabel.IsSelectionEnabled = false;
            this.ProdutosLabel.Location = new System.Drawing.Point(324, 3);
            this.ProdutosLabel.Name = "ProdutosLabel";
            this.ProdutosLabel.Size = new System.Drawing.Size(106, 42);
            this.ProdutosLabel.TabIndex = 1;
            this.ProdutosLabel.Text = "Produto";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(365, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(2, 1);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = resources.GetString("guna2HtmlLabel1.Text");
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProdutosLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}