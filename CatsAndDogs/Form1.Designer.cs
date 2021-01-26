namespace CatsAndDogs
{
    partial class Form1
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
            this.getDog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.catpicture = new System.Windows.Forms.PictureBox();
            this.getCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // getDog
            // 
            this.getDog.Location = new System.Drawing.Point(581, 357);
            this.getDog.Name = "getDog";
            this.getDog.Size = new System.Drawing.Size(75, 23);
            this.getDog.TabIndex = 0;
            this.getDog.Text = "GET DOG\r\n\r\n\r\n";
            this.getDog.UseVisualStyleBackColor = true;
            this.getDog.Click += new System.EventHandler(this.getDog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(434, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 310);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // catpicture
            // 
            this.catpicture.Location = new System.Drawing.Point(12, 41);
            this.catpicture.Name = "catpicture";
            this.catpicture.Size = new System.Drawing.Size(361, 310);
            this.catpicture.TabIndex = 2;
            this.catpicture.TabStop = false;
            this.catpicture.Click += new System.EventHandler(this.catpicture_Click);
            // 
            // getCat
            // 
            this.getCat.Location = new System.Drawing.Point(149, 357);
            this.getCat.Name = "getCat";
            this.getCat.Size = new System.Drawing.Size(75, 23);
            this.getCat.TabIndex = 3;
            this.getCat.Text = "CAT";
            this.getCat.UseVisualStyleBackColor = true;
            this.getCat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getCat);
            this.Controls.Add(this.catpicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getDog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getDog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox catpicture;
        private System.Windows.Forms.Button getCat;
    }
}

