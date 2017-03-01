using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KreationService
{
    [DataContract]
   public  class Product
    {
        [DataMember]
        private String invoiceno;

        public String InvoiceNo
        {
            get { return invoiceno; }
            set { invoiceno = value; }
        }

        [DataMember]
        private String barcode;

        public String Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        [DataMember]
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        private String price;

        public String Price
        {
            get { return price; }
            set { price = value; }
        }
        [DataMember]
        private String profit;

        public String Profit
        {
            get { return profit; }
            set { profit = value; }
        }
        [DataMember]
        private String qty;

        public String Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        [DataMember]
        private String total;

        public String Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
