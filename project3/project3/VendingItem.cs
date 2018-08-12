// CISS 233-300: Project 03
// Author:   Jay Morales
// Date:     February 23, 2018
// Project:  Vending Machine Simulator
// Purpose:  The objects of this class will represent the item in the vending machine.
namespace project3
{
    public class VendingItem
    {
        public string Item { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item">Item name</param>
        /// <param name="price">Price</param>
        /// <param name="location">Code Location</param>
        /// <param name="quantity">Quantity available</param>
        public VendingItem(string item = null, double price = 0, string location = null, int quantity = 0)
        {
            Item = item;
            Price = price < 0.0 ? 0 : price;
            Location = location;
            Quantity = quantity < 0 ? 0 : quantity;
        }

        /// <summary>
        /// Deducts one from the inventory when the item is purchased.
        /// </summary>
        /// <returns>True if enough for the purchase, otherwise false</returns>
        public bool ReduceInventory()
        {
            if (Quantity <= 0) return false;

            Quantity--;
            return true;
        }

        /// <summary>
        /// Return string that represent the item. 
        /// </summary>
        /// <returns>Item representation</returns>
        public override string ToString()
        {
            return $"[{Location}] {Item} {Price:C}";
        }
    }
}