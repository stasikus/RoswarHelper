namespace RoswarHelper
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
            this.loadListBtn = new System.Windows.Forms.Button();
            this.usersList = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadListBtn
            // 
            this.loadListBtn.Location = new System.Drawing.Point(12, 12);
            this.loadListBtn.Name = "loadListBtn";
            this.loadListBtn.Size = new System.Drawing.Size(75, 23);
            this.loadListBtn.TabIndex = 0;
            this.loadListBtn.Text = "Load_Users";
            this.loadListBtn.UseVisualStyleBackColor = true;
            this.loadListBtn.Click += new System.EventHandler(this.loadListBtn_Click);
            // 
            // usersList
            // 
            this.usersList.FormattingEnabled = true;
            this.usersList.Location = new System.Drawing.Point(12, 41);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(158, 355);
            this.usersList.TabIndex = 1;
            this.usersList.SelectedIndexChanged += new System.EventHandler(this.usersList_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.testBtn);
            this.groupBox.Location = new System.Drawing.Point(176, 41);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(393, 355);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Info";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(6, 19);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "test";
            this.testBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 413);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.loadListBtn);
            this.Name = "Form1";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadListBtn;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button testBtn;
    }
}

