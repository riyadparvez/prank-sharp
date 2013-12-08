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
        [ConfigurationProperty("Color")]
        public string Color 
        {
            get { return (string)this["Color"]; }
            set { this["Color"] = value; }
        }
    }
}
