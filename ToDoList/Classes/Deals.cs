using System;
using System.Collections.Generic;
using LowLevel;

namespace ToDoList
{
    [Serializable]
    public class Deals
    {
        IFile files;
        public List<Deal> deals { get; set; }
        public int Count { get => deals.Count; }
        public Deals()
        {
            files = new XmlFormat("../../Deals.xml");
            LoadFromFile();
        }
        public void CheckOverdue()
        {
            bool flag = false;
            foreach (var deal in deals)
            {
                int rez = DateTime.Compare(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), new DateTime(deal.date.year, deal.date.mounth, deal.date.day));
                if (rez == 1)
                {
                    deal.status = 1;
                    flag = true;
                }
            }
            if (flag)
            {
                this.SaveToFile();
                this.LoadFromFile();
            }
        }
        public void AddTask(Deal deal)
        {
            deals.Add(deal);
            this.SaveToFile();
        }
        public void Remove(Deal deal)
        {
            if (deals.Contains(deal))
            {
                deals.Remove(deal);
                this.SaveToFile();
            }
        }
        //////////
        //////////
        #region search_methods
        public Deal Search(string deal)
        {
            Deal temp=null;
            foreach(var d in deals)
            {
                if (d.ToString() == deal)
                {
                    temp = d;
                    break;
                }
                else temp = default(Deal);
            }
            return temp;
        }
        public Deal[]SearchByDeal(string deal)
        {
            Deal[] temp;
            int count = 0;
            foreach (var val in deals)
            {
                if (val.deal == deal)
                    count++;
            }
            if (count != 0)
            {
                temp = new Deal[count];
                count = 0;
                foreach (var val in deals)
                {
                    if (val.deal == deal)
                    {
                        temp[count] = val;
                        count++;
                    }
                }
                return temp;
            }
            return default(Deal[]);
        }
        public Deal[]SearchByDate(string date)
        {
            Deal[] temp;
            int count = 0;
            foreach (var val in deals)
            {
                if (val.date.ToString() == date)
                    count++;
            }
            if (count != 0)
            {
                temp = new Deal[count];
                count = 0;
                foreach (var val in deals)
                {
                    if (val.date.ToString() == date)
                    {
                        temp[count] = val;
                        count++;
                    }
                }
                return temp;
            }
            return default(Deal[]);
        }
        public Deal[] SearchByTime(string time)
        {
            Deal[] temp;
            int count = 0;
            foreach (var val in deals)
            {
                if (val.time.ToString()==time)
                    count++;
            }
            if (count != 0)
            {
                temp = new Deal[count];
                count = 0;
                foreach (var val in deals)
                {
                    if (val.time.ToString()==time)
                    {
                        temp[count] = val;
                        count++;
                    }
                }
                return temp;
            }
            return default(Deal[]);
        }
        public Deal[] SearchByTextTime(string time)
        {
            Deal[] temp;
            int count = 0;
            foreach (var val in deals)
            {
                if (val.text_time == time)
                    count++;
            }
            if (count != 0)
            {
                temp = new Deal[count];
                count = 0;
                foreach (var val in deals)
                {
                    if (val.text_time == time)
                    {
                        temp[count] = val;
                        count++;
                    }
                }
                return temp;
            }
            return default(Deal[]);
        }
       
        public Deal[]SearchByPriority(string priority)
        {
            {
                Deal[] temp;
                int count = 0;
                foreach (var val in deals)
                {
                    if (val.priority == priority)
                        count++;
                }
                if (count != 0)
                {
                    temp = new Deal[count];
                    count = 0;
                    foreach (var val in deals)
                    {
                        if (val.priority == priority)
                        {
                            temp[count] = val;
                            count++;
                        }
                    }
                    return temp;
                }
                return default(Deal[]);
            }
        }
        #endregion
        ///////////
        #region work_with_files
        public void SaveToFile()
        {
            files.Save(deals);
        }
        public void LoadFromFile()
        {
            if (files.Load<List<Deal>>() != null)
                deals = files.Load<List<Deal>>();
            else deals = new List<Deal>();

        }
        #endregion
        ///////////
        #region for_cycles
        public Deal this[int index]
        {
            get => deals[index];
            set => deals[index] = value;
        }
        public IEnumerator<Deal> GetEnumerator()
        {
            for (int i = 0; i < deals.Count; i++)
                yield return deals[i];
        }
        #endregion
        ///////////
    }
}
