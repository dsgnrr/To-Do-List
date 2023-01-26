using System;
using System.Collections.Generic;
using LowLevel;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        Deals deals;
        DealListName deal_list;
        bool dark_theme;
        
        public Form1()
        {
            InitializeComponent();
            deals = new Deals();
            deals.CheckOverdue();
            deal_list = new DealListName();
            status_box__fill();
            deal_list_box__fill();
            listBox1.ContextMenuStrip=contextMenuStrip1;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dark_theme = false;
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            this.Icon = Imges.app_logo;
        }
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        #region form_settings
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(3);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }
        private void theme_switch_click(object sender, EventArgs e)
        {
            if (!dark_theme)
            {
                dark_theme = true;
                this.BackColor = Color.FromArgb(21, 21, 21);
                listBox1.BackColor = Color.FromArgb(41, 41, 41);
                toolStrip1.BackColor = Color.FromArgb(21, 21, 21);

                deal_list_box.BackColor = Color.FromArgb(41, 41, 41);
                status_box.BackColor = Color.FromArgb(41, 41, 41);
                deal_list_box.ForeColor = Color.White;
                status_box.ForeColor = Color.White;

                contextMenuStrip2.ForeColor = Color.White;
                contextMenuStrip2.BackColor = Color.FromArgb(21, 21, 21);

                contextMenuStrip1.ForeColor = Color.White;
                contextMenuStrip1.BackColor = Color.FromArgb(21, 21, 21);

                search_but.Image = Imges.search_dark;
                about_button.Image = Imges.about_dark;
                exit_button.Image = Imges.exit_dark;


                theme_switch.Image = Imges.moon;

                add_button.BackColor = Color.FromArgb(21, 21, 21);
                add_button.ForeColor = Color.White;
            }
            else
            {
                dark_theme = false;
                deal_list_box.BackColor = Color.White;
                status_box.BackColor = Color.White;
                deal_list_box.ForeColor = Color.Black;
                status_box.ForeColor = Color.Black;

                this.BackColor = Color.White;

                listBox1.BackColor = Color.White;
                toolStrip1.BackColor = Color.White;

                contextMenuStrip2.ForeColor = Color.Black;
                contextMenuStrip2.BackColor = Color.White;

                contextMenuStrip1.ForeColor = Color.Black;
                contextMenuStrip1.BackColor = Color.White;

                search_but.Image = Imges.search_light;
                about_button.Image = Imges.about_light;
                exit_button.Image = Imges.exit_light;

                add_button.BackColor = Color.White;
                add_button.ForeColor = Color.Black;

                theme_switch.Image = Imges.sun;
            }
        }
        #endregion
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        #region comb_box_settings
        private void deal_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (deal_list_box.SelectedItem != null)
            {
                if (deals.Count != 0)
                {
                    deals.CheckOverdue();
                    foreach (var deal in deals)
                    {
                        if (deal.list_name == deal_list_box.SelectedItem.ToString())
                        {
                            if (deal.status == status_box.SelectedIndex)
                            {
                                set_listbox_color(status_box.SelectedIndex);
                                listBox1.Items.Add(deal);
                            }
                        }
                    }

                }
            }
        }
        void deal_list_box__fill()
        {
            deal_list_box.Items.Clear();
            deal_list.LoadFromFile();
            if (deal_list.Count != 0)
            {
                foreach (var name in deal_list)
                    deal_list_box.Items.Add(name);
                deal_list_box.SelectedIndex = 0;
            }
        }
        void status_box__fill()
        {
            status_box.Items.Add("Current");
            status_box.Items.Add("Overdue");
            status_box.Items.Add("Completed");
            status_box.SelectedIndex = 0;
        }
        #endregion
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        #region listbox_settings
        void set_listbox_color(int status)
        {
            Color[] color = new Color[] { Color.LightSeaGreen, Color.Brown, Color.SeaGreen };
            for (int i = 0; i < color.Length; i++)
            {
                if (status == i)
                    listBox1.ForeColor = color[i];
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //if(deal_list_box.SelectedIndex==0)
            //{
                foreach(var deal in deals)
                {
                    if (deal == listBox1.SelectedItem)
                    {
                        deal.status = 2;
                        deals.SaveToFile();
                        break;
                    }
                }
            //}
            
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        #endregion
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        #region contextMenu_settings
        private void contextmenu_click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Text == "Full info")
            {
                foreach (var deal in deals)
                {
                    if (listBox1.SelectedItem == deal)
                    {
                        if (deal.text_time == null)
                        {
                            MessageBox.Show($"Task: {deal.deal}\nDate: {deal.date}\nTime: {deal.time.hour.ToString()}:{deal.time.minutes.ToString()}\nPriority: {deal.priority}\nComment: {deal.comment}", "Full information", 0, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show($"Task: {deal.deal}\nDate: {deal.date}\nTime: {deal.text_time}\nPriority: {deal.priority}\nComment: {deal.comment}", "Full information", 0, MessageBoxIcon.Information);
                        break;
                    }
                }

            }
            if (item.Text == "Edit")
            {
                foreach (var deal in deals)
                {
                    if (listBox1.SelectedItem == deal)
                    {
                        DialogResult res = MessageBox.Show("Are you sure?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            deals.Remove(deal);
                            AddDeal addDeal = new AddDeal(dark_theme);
                            addDeal.parent_form = this;
                            res = addDeal.ShowDialog();
                            deals.LoadFromFile();
                            deals.CheckOverdue();
                            deal_list_box__fill();
                        }
                        break;
                    }
                }
            }
            if (item.Text == "Delete")
            {
                DialogResult res = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    foreach (var deal in deals)
                    {
                        if (listBox1.SelectedItem == deal)
                        {
                            deals.Remove(deal);
                            deals.LoadFromFile();
                            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                            MessageBox.Show("Succesfully", "Delete", 0, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
            }
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listBox1.SelectedItem == null)
                contextMenuStrip1.Enabled = false;
            else
                contextMenuStrip1.Enabled = true;
        }

        private void showApp(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void closeApp(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        #region buttons_settings
        
        private void add_button_Click(object sender, EventArgs e)
        {
            AddDeal addDeal = new AddDeal(dark_theme);
            addDeal.parent_form = this;

            //AddDeal.dark_theme_flag = true;
            addDeal.ShowDialog();
           
            deals.LoadFromFile();
            deals.CheckOverdue();
            deal_list_box__fill();
        }
        private void search_but_Click(object sender, EventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow(dark_theme);
            searchWindow.ShowDialog();
            deals.LoadFromFile();
        }
        private void about_button_Click(object sender, EventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.parent = this;
            DialogResult res = about.ShowDialog();

        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
        //////////////////////////////////////
    }
}
