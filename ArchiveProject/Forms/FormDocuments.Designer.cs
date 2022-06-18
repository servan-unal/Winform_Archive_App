
namespace ArchiveProject.Forms
{
    partial class FormDocuments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FfolderIdCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataTimeExpanse = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIncome = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.folderIdCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddDoc = new ArchiveProject.RJButton.RJButton();
            this.btnSelectDoc = new ArchiveProject.RJButton.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectDoc);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.folderIdCombo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(437, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 655);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddDoc);
            this.panel2.Controls.Add(this.dateTimeIncome);
            this.panel2.Controls.Add(this.dataTimeExpanse);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.typeCheckBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSubject);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FfolderIdCombobox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDocName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 655);
            this.panel2.TabIndex = 1;
            // 
            // FfolderIdCombobox
            // 
            this.FfolderIdCombobox.FormattingEnabled = true;
            this.FfolderIdCombobox.Location = new System.Drawing.Point(196, 125);
            this.FfolderIdCombobox.Name = "FfolderIdCombobox";
            this.FfolderIdCombobox.Size = new System.Drawing.Size(121, 24);
            this.FfolderIdCombobox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Folder Id :";
            // 
            // txtDocName
            // 
            this.txtDocName.Location = new System.Drawing.Point(196, 83);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(86, 22);
            this.txtDocName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Document Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(122, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Add Document ";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(196, 166);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(217, 32);
            this.txtSubject.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Subject : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Type :";
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Location = new System.Drawing.Point(196, 220);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(38, 21);
            this.typeCheckBox.TabIndex = 38;
            this.typeCheckBox.Text = "?";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Expanse Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Income Date :";
            // 
            // dataTimeExpanse
            // 
            this.dataTimeExpanse.Location = new System.Drawing.Point(196, 278);
            this.dataTimeExpanse.Name = "dataTimeExpanse";
            this.dataTimeExpanse.Size = new System.Drawing.Size(200, 22);
            this.dataTimeExpanse.TabIndex = 41;
            // 
            // dateTimeIncome
            // 
            this.dateTimeIncome.Location = new System.Drawing.Point(196, 328);
            this.dateTimeIncome.Name = "dateTimeIncome";
            this.dateTimeIncome.Size = new System.Drawing.Size(200, 22);
            this.dateTimeIncome.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(119, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Select Document ";
            // 
            // folderIdCombo
            // 
            this.folderIdCombo.FormattingEnabled = true;
            this.folderIdCombo.Location = new System.Drawing.Point(219, 128);
            this.folderIdCombo.Name = "folderIdCombo";
            this.folderIdCombo.Size = new System.Drawing.Size(121, 24);
            this.folderIdCombo.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 54;
            this.label13.Text = "Folder Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(14, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 337);
            this.dataGridView1.TabIndex = 56;
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddDoc.FlatAppearance.BorderSize = 0;
            this.btnAddDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDoc.ForeColor = System.Drawing.Color.White;
            this.btnAddDoc.Location = new System.Drawing.Point(139, 406);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(127, 34);
            this.btnAddDoc.TabIndex = 45;
            this.btnAddDoc.Text = "Add";
            this.btnAddDoc.UseVisualStyleBackColor = false;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnSelectDoc
            // 
            this.btnSelectDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectDoc.FlatAppearance.BorderSize = 0;
            this.btnSelectDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDoc.ForeColor = System.Drawing.Color.White;
            this.btnSelectDoc.Location = new System.Drawing.Point(203, 203);
            this.btnSelectDoc.Name = "btnSelectDoc";
            this.btnSelectDoc.Size = new System.Drawing.Size(127, 34);
            this.btnSelectDoc.TabIndex = 57;
            this.btnSelectDoc.Text = "Select";
            this.btnSelectDoc.UseVisualStyleBackColor = false;
            this.btnSelectDoc.Click += new System.EventHandler(this.btnSelectDoc_Click);
            // 
            // FormDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDocuments";
            this.Text = "FormDocuments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FfolderIdCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeIncome;
        private System.Windows.Forms.DateTimePicker dataTimeExpanse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.Label label9;
        private RJButton.RJButton btnAddDoc;
        private System.Windows.Forms.ComboBox folderIdCombo;
        private System.Windows.Forms.Label label13;
        private RJButton.RJButton btnSelectDoc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}