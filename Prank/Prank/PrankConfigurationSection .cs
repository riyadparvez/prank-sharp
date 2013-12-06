using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Prank
{
    class PrankConfigurationSection : System.Configuration.ConfigurationSection 
    {
        [ConfigurationProperty("schoolName")]
        public string SchoolName {
            get { return (string)this["schoolName"]; }
            set { this["schoolName"] = value; }
        }
    }
}
