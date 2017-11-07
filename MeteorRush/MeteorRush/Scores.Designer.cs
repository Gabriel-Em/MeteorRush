namespace MeteorRush
{
    partial class Scores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ScorDataGridView = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarMiscari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            this.ScorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ScorDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ScorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ScorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.Nume,
            this.NumarMiscari});
            this.ScorDataGridView.EnableHeadersVisualStyles = false;
            this.ScorDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ScorDataGridView.Name = "ScorDataGridView";
            this.ScorDataGridView.ReadOnly = true;
            this.ScorDataGridView.RowHeadersVisible = false;
            this.ScorDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ScorDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScorDataGridView.Size = new System.Drawing.Size(294, 246);
            this.ScorDataGridView.TabIndex = 1;
            // 
            // Place
            // 
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Width = 70;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Name";
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            this.Nume.Width = 120;
            // 
            // NumarMiscari
            // 
            this.NumarMiscari.HeaderText = "Score";
            this.NumarMiscari.Name = "NumarMiscari";
            this.NumarMiscari.ReadOnly = true;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(316, 276);
            this.Controls.Add(this.ScorDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Scores";
            this.Text = "Scores";
            ((System.ComponentModel.ISupportInitialize)(this.ScorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarMiscari;
    }
}