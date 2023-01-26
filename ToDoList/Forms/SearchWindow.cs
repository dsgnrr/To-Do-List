using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class SearchWindow : Form
    {
        DealListName dealList;
        Deals deals;
        bool dark_theme;
        public SearchWindow()
        {
            InitializeComponent();
            dealList = new DealListName();
            deals = new Deals();
        }
        public SearchWindow(bool flag)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dealList = new DealListName();
            deals = new Deals();
            dark_theme = flag;
            theme_switch(flag);
        }
        void theme_switch(bool flag)
        {
            if(flag)
            {
                this.BackColor = Color.FromArgb(21, 21, 21);
                listBox1.BackColor = Color.FromArgb(41, 41, 41);
                listBox1.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                RadioButton[] rb = new RadioButton[] { radioButton1, radioButton2, radioButton3 };
                for(int i=0;i<rb.Length;i++)
                {
                    rb[i].ForeColor = Color.White;
                }
                Button[] buttons = new Button[] { search_button, delete_button, edit_button };
                for(int i=0;i<buttons.Length;i++)
                {
                    buttons[i].BackColor = Color.FromArgb(14, 14, 14);
                    buttons[i].ForeColor = Color.White;
                }
                checkBox1.ForeColor = Color.White;
                property.BackColor = Color.FromArgb(14, 14, 14);
                property.ForeColor = Color.White;
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (deals.Count != 0)
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
        }



        #region buttons
        private void search_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (deals.Count != 0)
            {
                Deal[] deal = null;
                if (radioButton1.Checked)
                {
                    deal = deals.SearchByDeal(property.Text);
                    if (deal!=null)
                    {
                        foreach (var d in deal)
                            listBox1.Items.Add(d);
                    }
                    else
                        MessageBox.Show("Nothing found for your request", "Search.Error", 0, MessageBoxIcon.Error);
                }
                if (radioButton2.Checked)
                {
                    deal = deals.SearchByDate(property.Text);
                    if (deal != null)
                    {
                        foreach (var d in deal)
                            listBox1.Items.Add(d);
                    }
                    else
                        MessageBox.Show("Nothing found for your request", "Search.Error", 0, MessageBoxIcon.Error);
                }
                if (radioButton3.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        deal = deals.SearchByTextTime(property.Text);
                        if (deal != null)
                        {
                            foreach (var d in deal)
                                listBox1.Items.Add(d);
                        }
                        else
                            MessageBox.Show("Nothing found for your request", "Search.Error", 0, MessageBoxIcon.Error);
                    }
                    else
                    {
                        deal = deals.SearchByTime(property.Text);
                        if (deal != null)
                        {
                            foreach (var d in deal)
                                listBox1.Items.Add(d);
                        }
                        else
                            MessageBox.Show("Nothing found for your request", "Search.Error", 0, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
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
                    }
                    break;
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
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
        #endregion

        private void search_filter(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Visible = true;
                if (checkBox1.Checked)
                {
                    property.Text = "All day";
                    property.Enabled = false;
                }
                else
                {
                    property.Enabled = true;
                }
            }
            else
            {
                checkBox1.Visible = false;
            }
        }

        private void property_TextChanged(object sender, EventArgs e)
        {
            if (property.Text == String.Empty)
                search_button.Enabled = false;
            else search_button.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem==null)
            {
                delete_button.Enabled = false;
                edit_button.Enabled = false;
            }
            else
            {
                delete_button.Enabled = true;
                edit_button.Enabled = true;
            }
        }
    }
}
