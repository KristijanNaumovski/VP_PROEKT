namespace DontTapTheWhiteTiles
{
    partial class HighScores
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.rb100Tiles = new System.Windows.Forms.RadioButton();
            this.rb300Tiles = new System.Windows.Forms.RadioButton();
            this.rb1Min = new System.Windows.Forms.RadioButton();
            this.rb30Sec = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(23, 68);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(228, 304);
            this.listBox.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(23, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(176, 385);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rb100Tiles
            // 
            this.rb100Tiles.AutoSize = true;
            this.rb100Tiles.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb100Tiles.Location = new System.Drawing.Point(12, 12);
            this.rb100Tiles.Name = "rb100Tiles";
            this.rb100Tiles.Size = new System.Drawing.Size(103, 18);
            this.rb100Tiles.TabIndex = 3;
            this.rb100Tiles.Text = "100 Tiles Game";
            this.rb100Tiles.UseVisualStyleBackColor = true;
            this.rb100Tiles.CheckedChanged += new System.EventHandler(this.loadList);
            // 
            // rb300Tiles
            // 
            this.rb300Tiles.AutoSize = true;
            this.rb300Tiles.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb300Tiles.Location = new System.Drawing.Point(12, 36);
            this.rb300Tiles.Name = "rb300Tiles";
            this.rb300Tiles.Size = new System.Drawing.Size(103, 18);
            this.rb300Tiles.TabIndex = 4;
            this.rb300Tiles.Text = "300 Tiles Game";
            this.rb300Tiles.UseVisualStyleBackColor = true;
            this.rb300Tiles.CheckedChanged += new System.EventHandler(this.loadList);
            // 
            // rb1Min
            // 
            this.rb1Min.AutoSize = true;
            this.rb1Min.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.rb1Min.Location = new System.Drawing.Point(121, 39);
            this.rb1Min.Name = "rb1Min";
            this.rb1Min.Size = new System.Drawing.Size(104, 18);
            this.rb1Min.TabIndex = 5;
            this.rb1Min.Text = "1 Minute Game";
            this.rb1Min.UseVisualStyleBackColor = true;
            this.rb1Min.CheckedChanged += new System.EventHandler(this.loadList);
            // 
            // rb30Sec
            // 
            this.rb30Sec.AutoSize = true;
            this.rb30Sec.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb30Sec.Location = new System.Drawing.Point(121, 15);
            this.rb30Sec.Name = "rb30Sec";
            this.rb30Sec.Size = new System.Drawing.Size(119, 18);
            this.rb30Sec.TabIndex = 6;
            this.rb30Sec.Text = "30 Seconds Game";
            this.rb30Sec.UseVisualStyleBackColor = true;
            this.rb30Sec.CheckedChanged += new System.EventHandler(this.loadList);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 420);
            this.Controls.Add(this.rb30Sec);
            this.Controls.Add(this.rb1Min);
            this.Controls.Add(this.rb300Tiles);
            this.Controls.Add(this.rb100Tiles);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.listBox);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rb100Tiles;
        private System.Windows.Forms.RadioButton rb300Tiles;
        private System.Windows.Forms.RadioButton rb1Min;
        private System.Windows.Forms.RadioButton rb30Sec;
    }
}