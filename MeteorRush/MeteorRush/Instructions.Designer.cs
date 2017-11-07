namespace MeteorRush
{
    partial class Instructions
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
            this.btnPageLeft = new System.Windows.Forms.Button();
            this.btnPageRight = new System.Windows.Forms.Button();
            this.PagePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPageLeft
            // 
            this.btnPageLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnPageLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageLeft.Enabled = false;
            this.btnPageLeft.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnPageLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnPageLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPageLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageLeft.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageLeft.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnPageLeft.Location = new System.Drawing.Point(-4, 393);
            this.btnPageLeft.Name = "btnPageLeft";
            this.btnPageLeft.Size = new System.Drawing.Size(201, 49);
            this.btnPageLeft.TabIndex = 16;
            this.btnPageLeft.Text = "<<";
            this.btnPageLeft.UseVisualStyleBackColor = false;
            this.btnPageLeft.Click += new System.EventHandler(this.btnPageLeft_Click);
            // 
            // btnPageRight
            // 
            this.btnPageRight.BackColor = System.Drawing.Color.Transparent;
            this.btnPageRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageRight.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnPageRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnPageRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPageRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageRight.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageRight.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnPageRight.Location = new System.Drawing.Point(198, 393);
            this.btnPageRight.Name = "btnPageRight";
            this.btnPageRight.Size = new System.Drawing.Size(201, 49);
            this.btnPageRight.TabIndex = 18;
            this.btnPageRight.Text = ">>";
            this.btnPageRight.UseVisualStyleBackColor = false;
            this.btnPageRight.Click += new System.EventHandler(this.btnPageRight_Click);
            // 
            // PagePic
            // 
            this.PagePic.BackgroundImage = global::MeteorRush.Properties.Resources.InstructiuniP1;
            this.PagePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PagePic.Location = new System.Drawing.Point(-4, -5);
            this.PagePic.Name = "PagePic";
            this.PagePic.Size = new System.Drawing.Size(405, 398);
            this.PagePic.TabIndex = 0;
            this.PagePic.TabStop = false;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(399, 440);
            this.Controls.Add(this.btnPageRight);
            this.Controls.Add(this.btnPageLeft);
            this.Controls.Add(this.PagePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.Instructions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PagePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PagePic;
        private System.Windows.Forms.Button btnPageLeft;
        private System.Windows.Forms.Button btnPageRight;
    }
}