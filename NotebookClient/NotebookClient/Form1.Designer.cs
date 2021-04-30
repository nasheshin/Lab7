
namespace NotebookClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.clmFirstname = new System.Windows.Forms.ColumnHeader();
            this.clmSecondname = new System.Windows.Forms.ColumnHeader();
            this.clmBirthDay = new System.Windows.Forms.ColumnHeader();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFirstname,
            this.clmSecondname,
            this.clmBirthDay});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(538, 193);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // clmFirstname
            // 
            this.clmFirstname.Text = "Имя";
            this.clmFirstname.Width = 200;
            // 
            // clmSecondname
            // 
            this.clmSecondname.Text = "Фамилия";
            this.clmSecondname.Width = 200;
            // 
            // clmBirthDay
            // 
            this.clmBirthDay.Text = "Дата рождения";
            this.clmBirthDay.Width = 130;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 211);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(130, 51);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(148, 211);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(130, 51);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(284, 211);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(130, 51);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Изменить...";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.removeButton.Location = new System.Drawing.Point(420, 211);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(130, 51);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 272);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader clmFirstname;
        private System.Windows.Forms.ColumnHeader clmSecondname;
        private System.Windows.Forms.ColumnHeader clmBirthDay;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
    }
}

