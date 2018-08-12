using System;

namespace finalproject
{
    public class Order
    {
        public int Id { get; private set; }
        public int CustId { get; private set; }
        public string OrderDate { get; private set; }
        public string OrderTime { get; private set; }
        public int Prod1Qty { get; private set; }
        public int Prod2Qty { get; private set; }
        public int Prod3Qty { get; private set; }
        public int Prod4Qty { get; private set; }
        public int Prod5Qty { get; private set; }
        public int Prod6Qty { get; private set; }
        public decimal SubTotal { get; private set; }
        public decimal TaxAmt { get; private set;}
        public decimal GrandTotal { get; private set; }

        public Order(int id, int custId, string orderDate, string orderTime, int prod1Qty, int prod2Qty, int prod3Qty, int prod4Qty, int prod5Qty, int prod6Qty, decimal subTotal, decimal taxAmt, decimal grandTotal)
        {
            Id = id;
            CustId = custId;
            OrderDate = orderDate ?? throw new ArgumentNullException(nameof(orderDate));
            OrderTime = orderTime ?? throw new ArgumentNullException(nameof(orderTime));
            Prod1Qty = prod1Qty;
            Prod2Qty = prod2Qty;
            Prod3Qty = prod3Qty;
            Prod4Qty = prod4Qty;
            Prod5Qty = prod5Qty;
            Prod6Qty = prod6Qty;
            SubTotal = subTotal;
            TaxAmt = taxAmt;
            GrandTotal = grandTotal;
        }

        public Order(int custId, string orderDate, string orderTime, int prod1Qty, int prod2Qty, int prod3Qty, int prod4Qty, int prod5Qty, int prod6Qty, decimal subTotal, decimal taxAmt, decimal grandTotal)
        {
            CustId = custId;
            OrderDate = orderDate ?? throw new ArgumentNullException(nameof(orderDate));
            OrderTime = orderTime ?? throw new ArgumentNullException(nameof(orderTime));
            Prod1Qty = prod1Qty;
            Prod2Qty = prod2Qty;
            Prod3Qty = prod3Qty;
            Prod4Qty = prod4Qty;
            Prod5Qty = prod5Qty;
            Prod6Qty = prod6Qty;
            SubTotal = subTotal;
            TaxAmt = taxAmt;
            GrandTotal = grandTotal;
        }
    }
}