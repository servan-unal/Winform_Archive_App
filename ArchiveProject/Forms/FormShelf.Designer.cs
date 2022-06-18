
namespace ArchiveProject.Forms
{
    partial class FormShelf
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtShelfName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PartIdCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteShelf = new ArchiveProject.RJButton.RJButton();
            this.btnAddShelf = new ArchiveProject.RJButton.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 189);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtShelfName
            // 
            this.txtShelfName.Location = new System.Drawing.Point(380, 41);
            this.txtShelfName.Name = "txtShelfName";
            this.txtShelfName.Size = new System.Drawing.Size(86, 22);
            this.txtShelfName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Shelf Name : ";
            // 
            // PartIdCombobox
            // 
            this.PartIdCombobox.FormattingEnabled = true;
            this.PartIdCombobox.Location = new System.Drawing.Point(380, 86);
            this.PartIdCombobox.Name = "PartIdCombobox";
            this.PartIdCombobox.Size = new System.Drawing.Size(121, 24);
            this.PartIdCombobox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Part Id :";
            // 
            // btnDeleteShelf
            // 
            this.btnDeleteShelf.BackColor = System.Drawing.Color.Red;
            this.btnDeleteShelf.FlatAppearance.BorderSize = 0;
            this.btnDeleteShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShelf.ForeColor = System.Drawing.Color.White;
            this.btnDeleteShelf.Location = new System.Drawing.Point(228, 146);
            this.btnDeleteShelf.Name = "btnDeleteShelf";
            this.btnDeleteShelf.Size = new System.Drawing.Size(127, 34);
            this.btnDeleteShelf.TabIndex = 10;
            this.btnDeleteShelf.Text = "Delete";
            this.btnDeleteShelf.UseVisualStyleBackColor = false;
            this.btnDeleteShelf.Click += new System.EventHandler(this.btnDeleteShelf_Click);
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddShelf.FlatAppearance.BorderSize = 0;
            this.btnAddShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShelf.ForeColor = System.Drawing.Color.White;
            this.btnAddShelf.Location = new System.Drawing.Point(406, 146);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(127, 34);
            this.btnAddShelf.TabIndex = 6;
            this.btnAddShelf.Text = "Add";
            this.btnAddShelf.UseVisualStyleBackColor = false;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // FormShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PartIdCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteShelf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtShelfName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddShelf);
            this.Name = "FormShelf";
            this.Text = "FormShelf";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton.RJButton btnDeleteShelf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtShelfName;
        private System.Windows.Forms.Label label1;
        private RJButton.RJButton btnAddShelf;
        private System.Windows.Forms.ComboBox PartIdCombobox;
        private System.Windows.Forms.Label label2;
    }
}