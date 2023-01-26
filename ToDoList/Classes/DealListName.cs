using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LowLevel;

namespace ToDoList
{
    public class DealListName
    {
        IFile files;
        public List<string> list_name { get; set; }
        public int Count { get => list_name.Count; }
        public DealListName()
        {
            files = new BinnaryFile("../../NamesDeals.bin");
            list_name = new List<string>();
            this.LoadFromFile();
        }
        public void AddList(string list_name)
        {
            if (!this.list_name.Contains(list_name))
            {
                this.list_name.Add(list_name);
                this.SaveToFile();
            }
        }
        public void Remove(string list_name)
        {
            this.list_name.Remove(list_name);
            this.SaveToFile();
        }
        void SaveToFile()
        {
            files.Save(list_name);
        }
        public void LoadFromFile()
        {
            if (files.Load<List<string>>() != null)
                list_name = files.Load<List<string>>();
        }
        public string this[int index]
        {
            get => list_name[index];
            set => list_name[index] = value;
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < list_name.Count; i++)
                yield return list_name[i];
        }
    }
}
