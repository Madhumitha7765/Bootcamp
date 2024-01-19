using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProductStore
{
    internal class Product
    {
        private int m_intProdId;
        public int prodId
        {
            get { return m_intProdId; }
            set
            {
                if (value > 0)
                    m_intProdId = value;
                else
                    throw new Exception("Invalid prodid");
            }
        }

        private string m_strName;
        public string Name
        {
            get { return m_strName; }
            set
            {
                if (value.Length > 3)
                    m_strName = value;
                else
                    throw new Exception("Name should be at least 3 chars");
            }
        }

        private DateTime mfgDate;
        public DateTime MfgDate
        {
            get { return mfgDate; }
            set
            {
                if (value < DateTime.Today)
                    mfgDate = value;
                else
                    throw new Exception("Manufacturing date should be before today");
            }
        }

        private DateTime warranty;
        public DateTime Warranty
        {
            get { return warranty; }
            set
            {
                if (value < DateTime.Today)
                    warranty = value;
                else
                    throw new Exception("Warranty should be before today");
            }
        }

        private double m_dblPrice;

        public double ProdPrice
        {
            get { return m_dblPrice; }
            set
            {
                if (value > 0)
                    m_dblPrice = value;
                else
                    throw new Exception("Price should be greater than 0");
            }
        }

        private int m_dblStock;

        public int ProdStock
        {
            get { return m_dblStock; }
            set
            {
                if (value > 0)
                    m_dblStock = value;
                else
                    throw new Exception("Stock should be greater than 0");
            }
        }

        private double m_fltDiscount;

        public double ProdDiscount
        {
            get { return m_fltDiscount; }
            set
            {
                if (value >= 1 && value <= 30)
                    m_fltDiscount = value;
                else
                    throw new Exception("Discount should be between 1 and 30");
            }
        }

        public string Display()
        {
            double taxPrice = ProdPrice + ProdPrice * GetGST() / 100;
            double discountPrice = taxPrice - taxPrice * ProdDiscount/100;
            double totalPrice = discountPrice * ProdStock;

            return $"Product ID: {prodId}\nName: {Name}\nManufacturing Date: {MfgDate.ToShortDateString()}\nWarranty Date: {Warranty.ToShortDateString()}\nPrice: {ProdPrice}\nStock: {ProdStock}\nGST: {GetGST()}\nDiscount: {ProdDiscount}%\nTotal Price: {totalPrice}";
        }

        private int GetGST()
        {
            // GST logic (5/12/18/28)
            return 18;
        }
    }
}