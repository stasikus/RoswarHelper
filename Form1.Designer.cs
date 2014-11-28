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
            this.spendGold_25 = new System.Windows.Forms.Button();
            this.spendGold_75 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.await_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coint_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.patrol_btn = new System.Windows.Forms.Button();
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
            this.groupBox.Controls.Add(this.patrol_btn);
            this.groupBox.Controls.Add(this.spendGold_25);
            this.groupBox.Controls.Add(this.spendGold_75);
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.await_label);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.coint_label);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.name_label);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.testBtn);
            this.groupBox.Location = new System.Drawing.Point(176, 41);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(393, 355);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Info";
            // 
            // spendGold_25
            // 
            this.spendGold_25.Location = new System.Drawing.Point(6, 128);
            this.spendGold_25.Name = "spendGold_25";
            this.spendGold_25.Size = new System.Drawing.Size(121, 23);
            this.spendGold_25.TabIndex = 9;
            this.spendGold_25.Text = "Тратить золото (25)";
            this.spendGold_25.UseVisualStyleBackColor = true;
            this.spendGold_25.Click += new System.EventHandler(this.spendGold_25_Click);
            // 
            // spendGold_75
            // 
            this.spendGold_75.Location = new System.Drawing.Point(6, 157);
            this.spendGold_75.Name = "spendGold_75";
            this.spendGold_75.Size = new System.Drawing.Size(121, 23);
            this.spendGold_75.TabIndex = 8;
            this.spendGold_75.Text = "Тратить золото (75)";
            this.spendGold_75.UseVisualStyleBackColor = true;
            this.spendGold_75.Click += new System.EventHandler(this.spendGold_75_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 289);
            this.textBox1.TabIndex = 7;
            // 
            // await_label
            // 
            this.await_label.AutoSize = true;
            this.await_label.Location = new System.Drawing.Point(85, 67);
            this.await_label.Name = "await_label";
            this.await_label.Size = new System.Drawing.Size(0, 13);
            this.await_label.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "В ожидании: ";
            // 
            // coint_label
            // 
            this.coint_label.AutoSize = true;
            this.coint_label.Location = new System.Drawing.Point(54, 44);
            this.coint_label.Name = "coint_label";
            this.coint_label.Size = new System.Drawing.Size(0, 13);
            this.coint_label.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Монет:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(46, 21);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 13);
            this.name_label.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ник: ";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(6, 98);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "test (Heal)";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // patrol_btn
            // 
            this.patrol_btn.Location = new System.Drawing.Point(6, 186);
            this.patrol_btn.Name = "patrol_btn";
            this.patrol_btn.Size = new System.Drawing.Size(121, 23);
            this.patrol_btn.TabIndex = 10;
            this.patrol_btn.Text = "Патруль (40)";
            this.patrol_btn.UseVisualStyleBackColor = true;
            this.patrol_btn.Click += new System.EventHandler(this.patrol_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 413);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.loadListBtn);
            this.Name = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadListBtn;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label await_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label coint_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button spendGold_25;
        private System.Windows.Forms.Button spendGold_75;
        private System.Windows.Forms.Button patrol_btn;
    }
}

