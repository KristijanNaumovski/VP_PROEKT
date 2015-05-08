namespace DontTapTheWhiteTiles
{
    partial class SelectGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.rb100Tiles = new System.Windows.Forms.RadioButton();
            this.rb1Min = new System.Windows.Forms.RadioButton();
            this.rb300Tiles = new System.Windows.Forms.RadioButton();
            this.rb30Sek = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a game:";
            // 
            // rb100Tiles
            // 
            this.rb100Tiles.AutoSize = true;
            this.rb100Tiles.Checked = true;
            this.rb100Tiles.Location = new System.Drawing.Point(29, 82);
            this.rb100Tiles.Name = "rb100Tiles";
            this.rb100Tiles.Size = new System.Drawing.Size(76, 17);
            this.rb100Tiles.TabIndex = 1;
            this.rb100Tiles.TabStop = true;
            this.rb100Tiles.Text = "100 TILES";
            this.rb100Tiles.UseVisualStyleBackColor = true;
            // 
            // rb1Min
            // 
            this.rb1Min.AutoSize = true;
            this.rb1Min.Location = new System.Drawing.Point(148, 105);
            this.rb1Min.Name = "rb1Min";
            this.rb1Min.Size = new System.Drawing.Size(76, 17);
            this.rb1Min.TabIndex = 2;
            this.rb1Min.TabStop = true;
            this.rb1Min.Text = "1 MINUTE";
            this.rb1Min.UseVisualStyleBackColor = true;
            // 
            // rb300Tiles
            // 
            this.rb300Tiles.AutoSize = true;
            this.rb300Tiles.Location = new System.Drawing.Point(29, 105);
            this.rb300Tiles.Name = "rb300Tiles";
            this.rb300Tiles.Size = new System.Drawing.Size(76, 17);
            this.rb300Tiles.TabIndex = 3;
            this.rb300Tiles.TabStop = true;
            this.rb300Tiles.Text = "300 TILES";
            this.rb300Tiles.UseVisualStyleBackColor = true;
            // 
            // rb30Sek
            // 
            this.rb30Sek.AutoSize = true;
            this.rb30Sek.Location = new System.Drawing.Point(148, 82);
            this.rb30Sek.Name = "rb30Sek";
            this.rb30Sek.Size = new System.Drawing.Size(92, 17);
            this.rb30Sek.TabIndex = 4;
            this.rb30Sek.Text = "30 SECONDS";
            this.rb30Sek.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(30, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(148, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(248, 189);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rb30Sek);
            this.Controls.Add(this.rb300Tiles);
            this.Controls.Add(this.rb1Min);
            this.Controls.Add(this.rb100Tiles);
            this.Controls.Add(this.label1);
            this.Name = "SelectGame";
            this.Text = "SELECT A GAME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb100Tiles;
        private System.Windows.Forms.RadioButton rb1Min;
        private System.Windows.Forms.RadioButton rb300Tiles;
        private System.Windows.Forms.RadioButton rb30Sek;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}