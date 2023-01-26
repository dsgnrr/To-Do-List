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
    public partial class AddDeal : Form
    {
        public object parent_form { get; set; }
        Deals deals;
        DealListName listName;
        public AddDeal()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ///////////////////////////
            ///////////////////////////
            ///////////////////////////
            InitializeComponent();/////
            ///////////////////////////
            ///////////////////////////
            ///////////////////////////
            listName = new DealListName();
            listName.LoadFromFile();
            deals = new Deals();
            deal_date.MinDate = DateTime.Now;
            deal_time.Value = DateTime.Today;
            PushNamesOfDealList();
            PushPriority();
            DealList_check();
        }
        public AddDeal(bool flag)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ///////////////////////////
            ///////////////////////////
            ///////////////////////////
            InitializeComponent();/////
            ///////////////////////////
            ///////////////////////////
            ///////////////////////////
            listName = new DealListName();
            listName.LoadFromFile();
            deals = new Deals();
            deal_date.MinDate = DateTime.Now;
            deal_time.Value = DateTime.Today;

            PushNamesOfDealList();
            PushPriority();
            DealList_check();
            theme_switch(flag);
        }

        void theme_switch(bool flag)
        {
            if(flag)
            {
                this.BackColor = Color.FromArgb(21, 21, 21);
                Label[] labels = new Label[] { label1, label3, label4, label5, label6, label7 };
                foreach (var label in labels)
                    label.ForeColor = Color.White;
                TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3,deal_list,priority,temp_time};
                foreach(var textbox in textBoxes)
                {
                    textbox.ForeColor = Color.White;
                    textbox.BackColor = Color.FromArgb(14, 14, 14);
                }
                ComboBox[] combos = new ComboBox[] { check_box2, combo };
                foreach (var textbox in combos)
                {
                    textbox.ForeColor = Color.White;
                    textbox.BackColor = Color.FromArgb(14, 14, 14);
                }
                CheckBox[] checks = new CheckBox[] { checkBox1, checkBox2 };
                foreach (var label in checks)
                    label.ForeColor = Color.White;
            }
        }

        void DealList_check()
        {
            if (listName.Count == 0)
            {
                checkBox2.Checked = true;
                checkBox2.Enabled = false;
            }
        }
        void PushPriority()
        {
            check_box2.Items.Add("Low");
            check_box2.Items.Add("Middle");
            check_box2.Items.Add("High");
        }
        void PushNamesOfDealList()
        {
            if (listName.Count != 0)
            {
                foreach (var item in listName)
                {
                    combo.Items.Add(item);
                }

            }

        }
        private void deal_date_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = deal_date.Text;
        }
        #region buttons_settings
        private void ButtonBlock_textChang(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty || textBox1.Text == String.Empty || deal_list.Text == String.Empty || priority.Text == String.Empty)
                addButton.Enabled = false;
            else
            {
                bool flag = false;
                foreach (var deal in deals)
                {
                    if (deal.deal == textBox1.Text)
                        flag = true;
                }
                if (flag)
                    addButton.Enabled = false;
                else
                    addButton.Enabled = true;
            }
          
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Deal deal = new Deal();
            deal.deal = textBox1.Text;
            deal.date = new MyDate(deal_date.Value.Month, deal_date.Value.Day, deal_date.Value.Year);
            if (!checkBox1.Checked)
                deal.time = new MyTime(deal_time.Value.Hour, deal_time.Value.Minute);
            else deal.text_time = temp_time.Text;
            deal.priority = priority.Text;
            deal.list_name = deal_list.Text;
            listName.AddList(deal_list.Text);
            deal.status = 0;
            deal.comment = textBox3.Text;
            deals.AddTask(deal);
            MessageBox.Show("Deal add success", "Add information", 0, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion
       
        #region checkBox_settings
        private void checkBoxes_check(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                deal_time.Enabled = false;
                temp_time.Visible = true;
                temp_time.Text = "All day";
                temp_time.Enabled = false;
            }
            else
            {
                deal_time.Enabled = true;
                temp_time.Visible = false;
            }
            if(checkBox2.Checked)
            {
                combo.Enabled = false;
                deal_list.Enabled = true;
                
            }
            else
            {
                deal_list.Enabled = false;
                combo.Enabled = true;
            }
        }
        
        private void check_box2_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority.Text = check_box2.SelectedItem.ToString();   
        }
        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            deal_list.Text = combo.SelectedItem.ToString();
        }
        #endregion


    }
}
