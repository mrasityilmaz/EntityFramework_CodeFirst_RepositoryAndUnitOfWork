
namespace EF_EXAMPLE
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
            this.AddButton = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView_Peoples = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_Button = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.dataGridView_Jobs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_CurrentRowJobName = new System.Windows.Forms.Label();
            this.label_CurrentRowSurname = new System.Windows.Forms.Label();
            this.label_CurrentRowName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Peoples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jobs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(757, 430);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(169, 111);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(112, 430);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(204, 22);
            this.name_textBox.TabIndex = 1;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(112, 460);
            this.surname_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(204, 22);
            this.surname_textBox.TabIndex = 2;
            this.surname_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // dataGridView_Peoples
            // 
            this.dataGridView_Peoples.AllowUserToAddRows = false;
            this.dataGridView_Peoples.AllowUserToDeleteRows = false;
            this.dataGridView_Peoples.AllowUserToResizeRows = false;
            this.dataGridView_Peoples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Peoples.Location = new System.Drawing.Point(13, 47);
            this.dataGridView_Peoples.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Peoples.Name = "dataGridView_Peoples";
            this.dataGridView_Peoples.RowHeadersVisible = false;
            this.dataGridView_Peoples.RowHeadersWidth = 51;
            this.dataGridView_Peoples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Peoples.Size = new System.Drawing.Size(913, 347);
            this.dataGridView_Peoples.TabIndex = 3;
            this.dataGridView_Peoples.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 433);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname:";
            // 
            // update_Button
            // 
            this.update_Button.Location = new System.Drawing.Point(757, 549);
            this.update_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(169, 102);
            this.update_Button.TabIndex = 6;
            this.update_Button.Text = "Update";
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(757, 659);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(169, 105);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // dataGridView_Jobs
            // 
            this.dataGridView_Jobs.AllowUserToAddRows = false;
            this.dataGridView_Jobs.AllowUserToDeleteRows = false;
            this.dataGridView_Jobs.AllowUserToResizeRows = false;
            this.dataGridView_Jobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Jobs.Location = new System.Drawing.Point(13, 524);
            this.dataGridView_Jobs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Jobs.Name = "dataGridView_Jobs";
            this.dataGridView_Jobs.RowHeadersVisible = false;
            this.dataGridView_Jobs.RowHeadersWidth = 51;
            this.dataGridView_Jobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Jobs.Size = new System.Drawing.Size(303, 240);
            this.dataGridView_Jobs.TabIndex = 9;
            this.dataGridView_Jobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Jobs_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_CurrentRowJobName);
            this.panel1.Controls.Add(this.label_CurrentRowSurname);
            this.panel1.Controls.Add(this.label_CurrentRowName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(369, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 334);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(27, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Job Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(86, 503);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Listeden bir iş seçin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(488, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Önizleme";
            // 
            // label_CurrentRowJobName
            // 
            this.label_CurrentRowJobName.AutoSize = true;
            this.label_CurrentRowJobName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CurrentRowJobName.Location = new System.Drawing.Point(27, 224);
            this.label_CurrentRowJobName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CurrentRowJobName.Name = "label_CurrentRowJobName";
            this.label_CurrentRowJobName.Size = new System.Drawing.Size(0, 23);
            this.label_CurrentRowJobName.TabIndex = 11;
            // 
            // label_CurrentRowSurname
            // 
            this.label_CurrentRowSurname.AutoSize = true;
            this.label_CurrentRowSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CurrentRowSurname.Location = new System.Drawing.Point(27, 161);
            this.label_CurrentRowSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CurrentRowSurname.Name = "label_CurrentRowSurname";
            this.label_CurrentRowSurname.Size = new System.Drawing.Size(0, 23);
            this.label_CurrentRowSurname.TabIndex = 10;
            // 
            // label_CurrentRowName
            // 
            this.label_CurrentRowName.AutoSize = true;
            this.label_CurrentRowName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CurrentRowName.Location = new System.Drawing.Point(27, 102);
            this.label_CurrentRowName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CurrentRowName.Name = "label_CurrentRowName";
            this.label_CurrentRowName.Size = new System.Drawing.Size(0, 23);
            this.label_CurrentRowName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(13, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "PeopleList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 796);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_Jobs);
            this.Controls.Add(this.update_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Peoples);
            this.Controls.Add(this.surname_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.removeButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Peoples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.DataGridView dataGridView_Peoples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView dataGridView_Jobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_CurrentRowJobName;
        private System.Windows.Forms.Label label_CurrentRowSurname;
        private System.Windows.Forms.Label label_CurrentRowName;
        private System.Windows.Forms.Label label8;
    }
}

