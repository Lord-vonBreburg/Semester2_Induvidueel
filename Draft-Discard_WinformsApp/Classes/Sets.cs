using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft_Discard_WinformsApp.Classes
{
    public class Sets
    {
        private int SetID { set; get; }
        private string Name { set; get; }
        private string Date { set; get; }

        public Sets(int id, string name, string date)
        {
            this.SetID = id;
            this.Name = name;
            this.Date = date;
        }
        public int getSetID()
        {
            return this.SetID;
        }
        public string getSetName()
        {
            return this.Name;
        }
        public string getSetDate()
        {
            return this.Date;
        }
    }
}
