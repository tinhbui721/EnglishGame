namespace EnglishGame
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.close = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rank = new System.Windows.Forms.PictureBox();
            this.vocab = new System.Windows.Forms.PictureBox();
            this.sound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(1186, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 60);
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Location = new System.Drawing.Point(40, 584);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(353, 154);
            this.start.TabIndex = 1;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(418, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 380);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Rank
            // 
            this.Rank.BackColor = System.Drawing.Color.Transparent;
            this.Rank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rank.BackgroundImage")));
            this.Rank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rank.Location = new System.Drawing.Point(935, 242);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(292, 174);
            this.Rank.TabIndex = 3;
            this.Rank.TabStop = false;
            this.Rank.Click += new System.EventHandler(this.Rank_Click);
            // 
            // vocab
            // 
            this.vocab.BackColor = System.Drawing.Color.Transparent;
            this.vocab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vocab.BackgroundImage")));
            this.vocab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vocab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vocab.Location = new System.Drawing.Point(12, 284);
            this.vocab.Name = "vocab";
            this.vocab.Size = new System.Drawing.Size(297, 116);
            this.vocab.TabIndex = 4;
            this.vocab.TabStop = false;
            this.vocab.Click += new System.EventHandler(this.vocab_Click);
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound.BackgroundImage")));
            this.sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.Location = new System.Drawing.Point(6, 4);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(60, 60);
            this.sound.TabIndex = 28;
            this.sound.TabStop = false;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 750);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.vocab);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Game";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Rank;
        private System.Windows.Forms.PictureBox vocab;
        private System.Windows.Forms.PictureBox sound;
    }
}

