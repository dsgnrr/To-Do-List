
namespace ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deal_list_box = new System.Windows.Forms.ToolStripComboBox();
            this.status_box = new System.Windows.Forms.ToolStripComboBox();
            this.theme_switch = new System.Windows.Forms.ToolStripButton();
            this.add_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.full_info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.search_but = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deal_list_box,
            this.status_box,
            this.theme_switch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(371, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deal_list_box
            // 
            this.deal_list_box.Name = "deal_list_box";
            this.deal_list_box.Size = new System.Drawing.Size(121, 25);
            this.deal_list_box.SelectedIndexChanged += new System.EventHandler(this.deal_list_box_SelectedIndexChanged);
            // 
            // status_box
            // 
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(121, 25);
            this.status_box.SelectedIndexChanged += new System.EventHandler(this.deal_list_box_SelectedIndexChanged);
            // 
            // theme_switch
            // 
            this.theme_switch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.theme_switch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.theme_switch.Image = ((System.Drawing.Image)(resources.GetObject("theme_switch.Image")));
            this.theme_switch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.theme_switch.Name = "theme_switch";
            this.theme_switch.Size = new System.Drawing.Size(23, 22);
            this.theme_switch.Text = "Select theme";
            this.theme_switch.Click += new System.EventHandler(this.theme_switch_click);
            // 
            // add_button
            // 
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(304, 330);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(55, 48);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 361);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.full_info,
            this.toolStripSeparator2,
            this.edit,
            this.delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // full_info
            // 
            this.full_info.Name = "full_info";
            this.full_info.Size = new System.Drawing.Size(117, 22);
            this.full_info.Text = "Full info";
            this.full_info.Click += new System.EventHandler(this.contextmenu_click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(117, 22);
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.contextmenu_click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(117, 22);
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.contextmenu_click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "App still opened";
            this.notifyIcon1.BalloonTipTitle = "Click here!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToDoListToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(152, 54);
            // 
            // showToDoListToolStripMenuItem
            // 
            this.showToDoListToolStripMenuItem.Name = "showToDoListToolStripMenuItem";
            this.showToDoListToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.showToDoListToolStripMenuItem.Text = "Show ToDoList";
            this.showToDoListToolStripMenuItem.Click += new System.EventHandler(this.showApp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeApp);
            // 
            // exit_button
            // 
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_button.Image = global::ToDoList.Properties.Resources.exit_light;
            this.exit_button.Location = new System.Drawing.Point(249, 389);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(123, 47);
            this.exit_button.TabIndex = 4;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // about_button
            // 
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.about_button.Image = global::ToDoList.Properties.Resources.about_light;
            this.about_button.Location = new System.Drawing.Point(125, 389);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(123, 47);
            this.about_button.TabIndex = 4;
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // search_but
            // 
            this.search_but.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_but.Image = global::ToDoList.Properties.Resources.search_light;
            this.search_but.Location = new System.Drawing.Point(1, 389);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(123, 47);
            this.search_but.TabIndex = 4;
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 437);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox deal_list_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripComboBox status_box;
        private System.Windows.Forms.ToolStripButton theme_switch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem full_info;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showToDoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button search_but;
    }
}

