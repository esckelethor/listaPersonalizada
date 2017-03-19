namespace listaPersonalizada
{
    partial class lblPrecio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblPrecio));
            this.lblTxtPrecio = new System.Windows.Forms.Label();
            this.imgCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTxtPrecio
            // 
            this.lblTxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtPrecio.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtPrecio.Location = new System.Drawing.Point(11, 3);
            this.lblTxtPrecio.Name = "lblTxtPrecio";
            this.lblTxtPrecio.Size = new System.Drawing.Size(102, 23);
            this.lblTxtPrecio.TabIndex = 4;
            this.lblTxtPrecio.Text = "00000000";
            this.lblTxtPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgCoin
            // 
            this.imgCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCoin.Image = ((System.Drawing.Image)(resources.GetObject("imgCoin.Image")));
            this.imgCoin.Location = new System.Drawing.Point(108, 6);
            this.imgCoin.Name = "imgCoin";
            this.imgCoin.Size = new System.Drawing.Size(20, 20);
            this.imgCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCoin.TabIndex = 3;
            this.imgCoin.TabStop = false;
            // 
            // lblPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgCoin);
            this.Controls.Add(this.lblTxtPrecio);
            this.Name = "lblPrecio";
            this.Size = new System.Drawing.Size(131, 29);
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxtPrecio;
        private System.Windows.Forms.PictureBox imgCoin;
    }
}
