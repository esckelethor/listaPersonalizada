﻿namespace listaPersonalizada
{
    partial class itemToBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemToBuy));
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.imgCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // imgItem
            // 
            this.imgItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgItem.Image = global::listaPersonalizada.drawable.fallen_moon;
            this.imgItem.Location = new System.Drawing.Point(3, 3);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(62, 62);
            this.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgItem.TabIndex = 1;
            this.imgItem.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(80, 23);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(97, 30);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "0000000";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgCoin
            // 
            this.imgCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCoin.Image = ((System.Drawing.Image)(resources.GetObject("imgCoin.Image")));
            this.imgCoin.Location = new System.Drawing.Point(171, 26);
            this.imgCoin.Name = "imgCoin";
            this.imgCoin.Size = new System.Drawing.Size(20, 20);
            this.imgCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCoin.TabIndex = 7;
            this.imgCoin.TabStop = false;
            // 
            // itemToBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.imgCoin);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.imgItem);
            this.Name = "itemToBuy";
            this.Size = new System.Drawing.Size(192, 66);
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox imgCoin;
    }
}
