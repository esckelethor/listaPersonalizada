namespace listaPersonalizada
{
    partial class filaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filaLista));
            this.lblNombreItem = new System.Windows.Forms.Label();
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.imgCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreItem
            // 
            this.lblNombreItem.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreItem.Location = new System.Drawing.Point(71, 3);
            this.lblNombreItem.Name = "lblNombreItem";
            this.lblNombreItem.Size = new System.Drawing.Size(426, 39);
            this.lblNombreItem.TabIndex = 3;
            this.lblNombreItem.Text = "Fallen Moon";
            this.lblNombreItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filaLista_MouseDown);
            // 
            // imgItem
            // 
            this.imgItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgItem.Image = global::listaPersonalizada.drawable.fallen_moon;
            this.imgItem.Location = new System.Drawing.Point(5, 3);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(62, 62);
            this.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgItem.TabIndex = 0;
            this.imgItem.TabStop = false;
            this.imgItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filaLista_MouseDown);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(379, 40);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(102, 23);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "00000000";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrecio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filaLista_MouseDown);
            // 
            // imgCoin
            // 
            this.imgCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCoin.Image = ((System.Drawing.Image)(resources.GetObject("imgCoin.Image")));
            this.imgCoin.Location = new System.Drawing.Point(475, 43);
            this.imgCoin.Name = "imgCoin";
            this.imgCoin.Size = new System.Drawing.Size(20, 20);
            this.imgCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCoin.TabIndex = 5;
            this.imgCoin.TabStop = false;
            this.imgCoin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filaLista_MouseDown);
            // 
            // filaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.imgCoin);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreItem);
            this.Controls.Add(this.imgItem);
            this.Name = "filaLista";
            this.Size = new System.Drawing.Size(498, 68);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filaLista_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox imgCoin;
    }
}
