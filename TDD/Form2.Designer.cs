namespace TDD
{
    partial class ISBN
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.exitBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(848, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Red;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_154305;
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book List:";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.White;
            this.exitBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.Color.White;
            this.exitBtn1.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_161742;
            this.exitBtn1.Location = new System.Drawing.Point(945, 11);
            this.exitBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(105, 42);
            this.exitBtn1.TabIndex = 32;
            this.exitBtn1.Text = "Exit";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // ISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::TDD.Properties.Resources.Screenshot_2024_07_28_154305;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.exitBtn1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ISBN";
            this.Text = "ISBN";
            this.Load += new System.EventHandler(this.ISBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button exitBtn1;
    }
}
