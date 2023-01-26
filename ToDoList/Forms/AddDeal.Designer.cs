
namespace ToDoList
{
    partial class AddDeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeal));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.check_box2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deal_date = new System.Windows.Forms.DateTimePicker();
            this.deal_time = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.temp_time = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.TextBox();
            this.deal_list = new System.Windows.Forms.TextBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 186);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 72);
            this.textBox3.TabIndex = 6;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Brown;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel.Location = new System.Drawing.Point(169, 264);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(133, 33);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Comment";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addButton.Enabled = false;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(15, 264);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 33);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // check_box2
            // 
            this.check_box2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_box2.DropDownWidth = 105;
            this.check_box2.FormattingEnabled = true;
            this.check_box2.Location = new System.Drawing.Point(178, 70);
            this.check_box2.Name = "check_box2";
            this.check_box2.Size = new System.Drawing.Size(17, 21);
            this.check_box2.TabIndex = 5;
            this.check_box2.SelectedIndexChanged += new System.EventHandler(this.check_box2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.ButtonBlock_textChang);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Priority ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Time";
            // 
            // deal_date
            // 
            this.deal_date.CustomFormat = "M.dd.yyyy";
            this.deal_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deal_date.Location = new System.Drawing.Point(138, 70);
            this.deal_date.Name = "deal_date";
            this.deal_date.Size = new System.Drawing.Size(15, 20);
            this.deal_date.TabIndex = 2;
            this.deal_date.ValueChanged += new System.EventHandler(this.deal_date_ValueChanged);
            // 
            // deal_time
            // 
            this.deal_time.CustomFormat = "HH:MM";
            this.deal_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deal_time.Location = new System.Drawing.Point(15, 119);
            this.deal_time.Name = "deal_time";
            this.deal_time.ShowUpDown = true;
            this.deal_time.Size = new System.Drawing.Size(138, 20);
            this.deal_time.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.ButtonBlock_textChang);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is to be done?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Deal List";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "All day";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxes_check);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(178, 145);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Create New";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBoxes_check);
            // 
            // temp_time
            // 
            this.temp_time.Location = new System.Drawing.Point(15, 119);
            this.temp_time.Name = "temp_time";
            this.temp_time.Size = new System.Drawing.Size(138, 20);
            this.temp_time.TabIndex = 8;
            this.temp_time.Visible = false;
            // 
            // priority
            // 
            this.priority.Enabled = false;
            this.priority.Location = new System.Drawing.Point(194, 70);
            this.priority.Multiline = true;
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(105, 21);
            this.priority.TabIndex = 10;
            this.priority.TextChanged += new System.EventHandler(this.ButtonBlock_textChang);
            // 
            // deal_list
            // 
            this.deal_list.Enabled = false;
            this.deal_list.Location = new System.Drawing.Point(194, 119);
            this.deal_list.Multiline = true;
            this.deal_list.Name = "deal_list";
            this.deal_list.Size = new System.Drawing.Size(105, 21);
            this.deal_list.TabIndex = 9;
            this.deal_list.TextChanged += new System.EventHandler(this.ButtonBlock_textChang);
            // 
            // combo
            // 
            this.combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combo.DropDownWidth = 105;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(178, 119);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(17, 21);
            this.combo.TabIndex = 5;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // AddDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 318);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.deal_list);
            this.Controls.Add(this.temp_time);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.deal_date);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.check_box2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deal_time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDeal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox check_box2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker deal_date;
        private System.Windows.Forms.DateTimePicker deal_time;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox temp_time;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.TextBox deal_list;
        private System.Windows.Forms.ComboBox combo;
    }
}