
namespace ArchiveProject.Forms
{
    partial class FormParts
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
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletePart = new ArchiveProject.RJButton.RJButton();
            this.btnAddPart = new ArchiveProject.RJButton.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.roomIdCombobox = new System.Windows.Forms.ComboBox();
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
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(380, 41);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(86, 22);
            this.txtPartName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parts Name";
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.BackColor = System.Drawing.Color.Red;
            this.btnDeletePart.FlatAppearance.BorderSize = 0;
            this.btnDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePart.ForeColor = System.Drawing.Color.White;
            this.btnDeletePart.Location = new System.Drawing.Point(228, 146);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(127, 34);
            this.btnDeletePart.TabIndex = 10;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPart.FlatAppearance.BorderSize = 0;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.ForeColor = System.Drawing.Color.White;
            this.btnAddPart.Location = new System.Drawing.Point(406, 146);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(127, 34);
            this.btnAddPart.TabIndex = 6;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room Id";
            // 
            // roomIdCombobox
            // 
            this.roomIdCombobox.FormattingEnabled = true;
            this.roomIdCombobox.Location = new System.Drawing.Point(380, 90);
            this.roomIdCombobox.Name = "roomIdCombobox";
            this.roomIdCombobox.Size = new System.Drawing.Size(121, 24);
            this.roomIdCombobox.TabIndex = 12;
            // 
            // FormParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomIdCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPart);
            this.Name = "FormParts";
            this.Text = "FormParts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton.RJButton btnDeletePart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label1;
        private RJButton.RJButton btnAddPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomIdCombobox;
    }
}