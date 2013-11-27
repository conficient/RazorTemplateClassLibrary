using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    /// <summary>
    /// A test model class for our Razor view
    /// </summary>
    public class OrderModel
    {
        public string CustomerName { get { return "Wile E Coyote"; } }
        
        public string CompanyName { get { return "Acme Corporation"; } }

        public string Url { get { return "http://www.acme.org"; } }

        public DateTime DeliveryDate { get { return DateTime.Today.AddDays(1); } }

        public IEnumerable<string> ProductsOrdered
        {
            get
            {
                return new string[] {"Anvil", "Rocket Sled", "Road Runner Trap"};
            }
        }
    }
}
