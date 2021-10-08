using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft_Discard_WinformsApp.Classes
{
    public class Sets
    {
        private int ID;
        private string Name;
        private string Date;

        public Sets(int SetID, string SetName, string SetDate)
        {
            this.ID = SetID;
            this.Name = SetName;
            this.Date = SetDate;
        }
        public int SetID
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.ID = value;
            }
        }
        public string SetName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public string SetDate
        {
            get
            {
                return this.Date;
            }
            set
            {
                this.Date = value;
            }
        }
    }
}
