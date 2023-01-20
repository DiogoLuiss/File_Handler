using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{

    public class CurrentAccount
    {

      public  static List<CurrentAccount> ListAccount = new List<CurrentAccount>();

        public int NumberAgency { get; private set; }
        public int NumberAccount { get; private set; }
        public double Balance { get;  set; }
        public string NameClient { get; set; }


      public CurrentAccount(int NumberAgency, int NumberAccount)
        {
            this.NumberAgency = NumberAgency;   
            this.NumberAccount = NumberAccount;


        }


    }
}
