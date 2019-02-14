namespace Music_Database
{
    partial class frmMusicPlayer
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
            this.musicDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchTrack = new System.Windows.Forms.Button();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comSearchBox = new System.Windows.Forms.ComboBox();
            this.btnShowTracks = new System.Windows.Forms.Button();
            this.btnShowAllTracks = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // musicDataView
            // 
            this.musicDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musicDataView.Location = new System.Drawing.Point(22, 69);
            this.musicDataView.Name = "musicDataView";
            this.musicDataView.Size = new System.Drawing.Size(728, 403);
            this.musicDataView.TabIndex = 0;
            this.musicDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musicDataView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(300, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Music Player";
            // 
            // btnSearchTrack
            // 
            this.btnSearchTrack.BackColor = System.Drawing.Color.Thistle;
            this.btnSearchTrack.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTrack.Location = new System.Drawing.Point(321, 491);
            this.btnSearchTrack.Name = "btnSearchTrack";
            this.btnSearchTrack.Size = new System.Drawing.Size(76, 38);
            this.btnSearchTrack.TabIndex = 6;
            this.btnSearchTrack.Text = "Search";
            this.btnSearchTrack.UseVisualStyleBackColor = false;
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddMusic.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMusic.Location = new System.Drawing.Point(234, 490);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(75, 38);
            this.btnAddMusic.TabIndex = 9;
            this.btnAddMusic.Text = "Add";
            this.btnAddMusic.UseVisualStyleBackColor = false;
            this.btnAddMusic.Click += new System.EventHandler(this.btnCreateAlbum_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(546, 501);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 21);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearchTrack_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // comSearchBox
            // 
            this.comSearchBox.FormattingEnabled = true;
            this.comSearchBox.Items.AddRange(new object[] {
            "Track",
            ""});
            this.comSearchBox.Location = new System.Drawing.Point(419, 501);
            this.comSearchBox.Name = "comSearchBox";
            this.comSearchBox.Size = new System.Drawing.Size(121, 21);
            this.comSearchBox.TabIndex = 12;
            // 
            // btnShowTracks
            // 
            this.btnShowTracks.BackColor = System.Drawing.Color.SkyBlue;
            this.btnShowTracks.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTracks.Location = new System.Drawing.Point(115, 492);
            this.btnShowTracks.Name = "btnShowTracks";
            this.btnShowTracks.Size = new System.Drawing.Size(102, 36);
            this.btnShowTracks.TabIndex = 13;
            this.btnShowTracks.Text = "Show Tracks";
            this.btnShowTracks.UseVisualStyleBackColor = false;
            this.btnShowTracks.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnShowAllTracks
            // 
            this.btnShowAllTracks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowAllTracks.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTracks.Location = new System.Drawing.Point(22, 491);
            this.btnShowAllTracks.Name = "btnShowAllTracks";
            this.btnShowAllTracks.Size = new System.Drawing.Size(75, 38);
            this.btnShowAllTracks.TabIndex = 14;
            this.btnShowAllTracks.Text = "Show All";
            this.btnShowAllTracks.UseVisualStyleBackColor = false;
            this.btnShowAllTracks.Click += new System.EventHandler(this.btnShowAllTracks_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(322, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(761, 594);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowAllTracks);
            this.Controls.Add(this.btnShowTracks);
            this.Controls.Add(this.comSearchBox);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musicDataView);
            this.Controls.Add(this.btnAddMusic);
            this.Name = "frmMusicPlayer";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.frmMusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView musicDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchTrack;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comSearchBox;
        private System.Windows.Forms.Button btnShowTracks;
        private System.Windows.Forms.Button btnShowAllTracks;
        private System.Windows.Forms.Button btnClose;
    }
}

