using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions_League_draw
{
    public class Teams
    {
       private string teamName;
       private string countryName;
       
        public Teams(string name,string country)
        {
            teamName = name;
            countryName = country;
        }
        public string TeamName
        {
            get
            {
                return teamName;
            }
            set
            {
                teamName = value;
            }
        }
        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
            }
        }
        public override string ToString()
        {
            return countryName + "-" + teamName;
        }
    }
}
