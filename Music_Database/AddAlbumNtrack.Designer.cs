namespace Music_Database
{
    partial class AddAlbumNtrack
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
            this.txtBoxAlbumName = new System.Windows.Forms.TextBox();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.newAlbumNtrackView = new System.Windows.Forms.DataGridView();
            this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCheckoutBack = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newAlbumNtrackView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxAlbumName
            // 
            this.txtBoxAlbumName.Location = new System.Drawing.Point(127, 20);
            this.txtBoxAlbumName.Name = "txtBoxAlbumName";
            this.txtBoxAlbumName.Size = new System.Drawing.Size(308, 20);
            this.txtBoxAlbumName.TabIndex = 19;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumName.Location = new System.Drawing.Point(28, 21);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(93, 17);
            this.lblAlbumName.TabIndex = 18;
            this.lblAlbumName.Text = "Album Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdd.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(425, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // newAlbumNtrackView
            // 
            this.newAlbumNtrackView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newAlbumNtrackView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Track});
            this.newAlbumNtrackView.Location = new System.Drawing.Point(22, 117);
            this.newAlbumNtrackView.Name = "newAlbumNtrackView";
            this.newAlbumNtrackView.Size = new System.Drawing.Size(543, 197);
            this.newAlbumNtrackView.TabIndex = 20;
            // 
            // Track
            // 
            this.Track.HeaderText = "Track Name";
            this.Track.Name = "Track";
            this.Track.Width = 500;
            // 
            // buttonCheckoutBack
            // 
            this.buttonCheckoutBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCheckoutBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonCheckoutBack.Location = new System.Drawing.Point(22, 339);
            this.buttonCheckoutBack.Name = "buttonCheckoutBack";
            this.buttonCheckoutBack.Size = new System.Drawing.Size(60, 40);
            this.buttonCheckoutBack.TabIndex = 44;
            this.buttonCheckoutBack.Text = "◀";
            this.buttonCheckoutBack.UseVisualStyleBackColor = false;
            this.buttonCheckoutBack.Click += new System.EventHandler(this.buttonCheckoutBack_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 20);
            this.textBox2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Artist Name";
            // 
            // AddAlbumNtrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 417);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCheckoutBack);
            this.Controls.Add(this.newAlbumNtrackView);
            this.Controls.Add(this.txtBoxAlbumName);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddAlbumNtrack";
            this.Text = "AddAlbumNtrack";
            ((System.ComponentModel.ISupportInitialize)(this.newAlbumNtrackView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAlbumName;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView newAlbumNtrackView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Track;
        private System.Windows.Forms.Button buttonCheckoutBack;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}