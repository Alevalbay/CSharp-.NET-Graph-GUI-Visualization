namespace Graph_Implementation {
    partial class FloydCostTable {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pbTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTable
            // 
            this.pbTable.BackColor = System.Drawing.Color.White;
            this.pbTable.Location = new System.Drawing.Point(12, 12);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(480, 480);
            this.pbTable.TabIndex = 0;
            this.pbTable.TabStop = false;
            // 
            // FloydCostTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 504);
            this.Controls.Add(this.pbTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FloydCostTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Floyd Warshall Cost Table";
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTable;
    }
}