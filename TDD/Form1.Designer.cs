
using System.Drawing;

namespace TDD
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
            this.components = new System.ComponentModel.Container();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.AutherName = new System.Windows.Forms.TextBox();
            this.PublichYear = new System.Windows.Forms.TextBox();
            this.Catorgy = new System.Windows.Forms.TextBox();
            this.QStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bookslist = new System.Windows.Forms.Button();
            this.Addbooks = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Insertbook = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.ForeColor = System.Drawing.Color.Black;
            this.ISBN.Location = new System.Drawing.Point(51, 173);
            this.ISBN.Multiline = true;
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(113, 29);
            this.ISBN.TabIndex = 0;
            this.ISBN.Tag = "";
            this.ISBN.Text = "ISBN:";
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            this.ISBN.Enter += new System.EventHandler(this.ISBN_Enter);
            this.ISBN.Leave += new System.EventHandler(this.ISBN_Leave);
            // 
            // BookName
            // 
            this.BookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(54, 232);
            this.BookName.Multiline = true;
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(113, 29);
            this.BookName.TabIndex = 1;
            this.BookName.Text = "Book Name:";
            this.BookName.TextChanged += new System.EventHandler(this.BookName_TextChanged);
            this.BookName.Enter += new System.EventHandler(this.BookName_Enter);
            this.BookName.Leave += new System.EventHandler(this.BookName_Leave);
            // 
            // AutherName
            // 
            this.AutherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AutherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutherName.Location = new System.Drawing.Point(54, 303);
            this.AutherName.Multiline = true;
            this.AutherName.Name = "AutherName";
            this.AutherName.Size = new System.Drawing.Size(113, 29);
            this.AutherName.TabIndex = 2;
            this.AutherName.Text = "Authur\'s Name:";
            this.AutherName.TextChanged += new System.EventHandler(this.AutherName_TextChanged);
            this.AutherName.Enter += new System.EventHandler(this.AutherName_Enter);
            this.AutherName.Leave += new System.EventHandler(this.AutherName_Leave);
            // 
            // PublichYear
            // 
            this.PublichYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PublichYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublichYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublichYear.Location = new System.Drawing.Point(241, 172);
            this.PublichYear.Multiline = true;
            this.PublichYear.Name = "PublichYear";
            this.PublichYear.Size = new System.Drawing.Size(113, 29);
            this.PublichYear.TabIndex = 3;
            this.PublichYear.Text = "Publish Year:";
            this.PublichYear.TextChanged += new System.EventHandler(this.PublichYear_TextChanged);
            this.PublichYear.Enter += new System.EventHandler(this.PublichYear_Enter);
            this.PublichYear.Leave += new System.EventHandler(this.PublichYear_Leave);
            // 
            // Catorgy
            // 
            this.Catorgy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Catorgy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Catorgy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catorgy.Location = new System.Drawing.Point(241, 231);
            this.Catorgy.Multiline = true;
            this.Catorgy.Name = "Catorgy";
            this.Catorgy.Size = new System.Drawing.Size(113, 29);
            this.Catorgy.TabIndex = 4;
            this.Catorgy.Text = "Category:";
            this.Catorgy.TextChanged += new System.EventHandler(this.Catorgy_TextChanged);
            this.Catorgy.Enter += new System.EventHandler(this.Catorgy_Enter);
            this.Catorgy.Leave += new System.EventHandler(this.Catorgy_Leave);
            // 
            // QStatus
            // 
            this.QStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.QStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QStatus.Location = new System.Drawing.Point(241, 303);
            this.QStatus.Multiline = true;
            this.QStatus.Name = "QStatus";
            this.QStatus.Size = new System.Drawing.Size(113, 29);
            this.QStatus.TabIndex = 5;
            this.QStatus.Text = "Question Status:";
            this.QStatus.TextChanged += new System.EventHandler(this.QStatus_TextChanged);
            this.QStatus.Enter += new System.EventHandler(this.QStatus_Enter);
            this.QStatus.Leave += new System.EventHandler(this.QStatus_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_154305;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add a book details:";
            // 
            // Bookslist
            // 
            this.Bookslist.BackColor = System.Drawing.Color.White;
            this.Bookslist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bookslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookslist.ForeColor = System.Drawing.Color.White;
            this.Bookslist.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_161742;
            this.Bookslist.Location = new System.Drawing.Point(469, 272);
            this.Bookslist.Name = "Bookslist";
            this.Bookslist.Size = new System.Drawing.Size(207, 60);
            this.Bookslist.TabIndex = 26;
            this.Bookslist.Text = "Books list";
            this.Bookslist.UseVisualStyleBackColor = false;
            this.Bookslist.Click += new System.EventHandler(this.Bookslist_Click);
            // 
            // Addbooks
            // 
            this.Addbooks.BackColor = System.Drawing.Color.White;
            this.Addbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbooks.ForeColor = System.Drawing.Color.White;
            this.Addbooks.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_161742;
            this.Addbooks.Location = new System.Drawing.Point(469, 173);
            this.Addbooks.Name = "Addbooks";
            this.Addbooks.Size = new System.Drawing.Size(207, 60);
            this.Addbooks.TabIndex = 27;
            this.Addbooks.Text = "Add 10000 books";
            this.Addbooks.UseVisualStyleBackColor = false;
            this.Addbooks.Click += new System.EventHandler(this.Addbooks_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_154305;
            this.label15.Location = new System.Drawing.Point(87, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(620, 65);
            this.label15.TabIndex = 29;
            this.label15.Text = "Library managment system";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Insertbook
            // 
            this.Insertbook.BackColor = System.Drawing.Color.DimGray;
            this.Insertbook.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Insertbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbook.ForeColor = System.Drawing.Color.White;
            this.Insertbook.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_161742;
            this.Insertbook.Location = new System.Drawing.Point(98, 357);
            this.Insertbook.Name = "Insertbook";
            this.Insertbook.Size = new System.Drawing.Size(207, 60);
            this.Insertbook.TabIndex = 30;
            this.Insertbook.Text = "Insert book details";
            this.Insertbook.UseVisualStyleBackColor = false;
            this.Insertbook.Click += new System.EventHandler(this.Insertbook_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = global::TDD.Properties.Resources.Screenshot_2024_07_28_161742;
            this.exitBtn.Location = new System.Drawing.Point(743, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 34);
            this.exitBtn.TabIndex = 31;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TDD.Properties.Resources.Screenshot_2024_07_28_154305;
            this.ClientSize = new System.Drawing.Size(832, 429);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.Insertbook);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Addbooks);
            this.Controls.Add(this.Bookslist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QStatus);
            this.Controls.Add(this.Catorgy);
            this.Controls.Add(this.PublichYear);
            this.Controls.Add(this.AutherName);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.ISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox AutherName;
        private System.Windows.Forms.TextBox PublichYear;
        private System.Windows.Forms.TextBox Catorgy;
        private System.Windows.Forms.TextBox QStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bookslist;
        private System.Windows.Forms.Button Addbooks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Insertbook;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

