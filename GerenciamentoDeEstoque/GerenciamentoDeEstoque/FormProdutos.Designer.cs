namespace GerenciamentoDeEstoque
{
    partial class FormProdutos
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PedidosLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.PedidosLabel);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-1, -2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(787, 51);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // PedidosLabel
            // 
            this.PedidosLabel.BackColor = System.Drawing.Color.Transparent;
            this.PedidosLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.PedidosLabel.IsSelectionEnabled = false;
            this.PedidosLabel.Location = new System.Drawing.Point(324, 3);
            this.PedidosLabel.Name = "PedidosLabel";
            this.PedidosLabel.Size = new System.Drawing.Size(104, 42);
            this.PedidosLabel.TabIndex = 0;
            this.PedidosLabel.Text = "Pedidos";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(787, 420);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel PedidosLabel;
    }
}