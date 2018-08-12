// CISS 233-300: Project 03
// Author:   Jay Morales
// Date:     February 23, 2018
// Project:  Vending Machine Simulator
// Purpose:  This program will mimic a vending machine.

using System.Collections.Generic;
using static System.Console;

namespace project3  
{
    internal class Program
    {
        private static List<VendingItem> items;
        private VendingItem itemPicked;
        private string picked;
        private int input;

        /// <summary>
        /// Instantiate objects of type VendingItem and fill the machine with items.
        /// </summary>
        /// <returns>The machine filled with items</returns>
        private Program FillMachine()
        {
            items = new List<VendingItem>
            {
                new VendingItem("Pepsi 20 oz", 2.25, "A1", 6),
                new VendingItem("Sierra Mist 20 oz", 2.25, "A2", 5),
                new VendingItem("Diet Pepsi 20 oz", 2.25, "A3", 5),
                new VendingItem("Snapple Lemon tea 16 oz", 1.55, "B1", 7),
                new VendingItem("Snapple Diet Lemon tea 16 oz", 1.55, "B2", 6),
                new VendingItem("Snapple Raspberry tea 16 oz", 1.55, "B3", 3),
                new VendingItem("Lays Potato Chips", 1.15, "C1", 6),
                new VendingItem("Cheetos", 1.05, "C2", 5),
                new VendingItem("Doritos Cool Ranch", 1.25, "C3", 8),
                new VendingItem("Twix Bar", 0.95, "D1", 6),
                new VendingItem("Kit-Kat", 0.95, "D2", 5),
                new VendingItem("Twizzlers", 0.85, "D3", 2),
                new VendingItem("Juicy Fruit Gum", 0.55, "E1", 9),
                new VendingItem("Tic-Tacs", 0.90, "E2", 8),
                new VendingItem("Doublemint Gum", 0.65, "E3", 4)
            };

            return this;
        }

        /// <summary>
        /// Class method, that return a string to display to the screen with their change.
        /// </summary>
        /// <param name="item">Item purchased.</param>
        /// <param name="money">Money inserted.</param>
        /// <returns>String to display to the screen</returns>
        private static string MakeChange(VendingItem item, int money)
        {
            var output = "";
            var cents = item != null ? (money - (decimal)item.Price) * 100M : money * 100M;
            int dollar, quarter, dime, nickel, counter = 0;

            counter += (dollar = (int)(cents / 100M)) > 0 ? 1 : 0;
            counter += (quarter = (int)((cents %= 100M) / 25M)) > 0 ? 1 : 0;
            counter += (dime = (int)((cents %= 25M) / 10M)) > 0 ? 1 : 0;
            counter += (nickel = (int)((cents % 10M) / 5M)) > 0 ? 1 : 0;

            output += dollar == 1 ? $"{dollar} dollar coin" : dollar > 1 ? $"{dollar} dollar coins" : "";
            if (dollar > 0)
                output += --counter == 1 ? " and " : counter > 1 ? ", " : "";

            output += quarter == 1 ? $"{quarter} quarter" : quarter > 1 ? $"{quarter} quarters" : "";
            if (quarter > 0)
                output += --counter == 1 ? " and " : counter > 1 ? ", " : "";

            output += dime == 1 ? $"{dime} dime" : dime > 1 ? $"{dime} dimes" : "";
            if (dime > 0)
                output += --counter == 1 ? " and " : counter > 2 ? ", " : "";

            output += nickel == 1 ? $"{nickel} nickel" : nickel > 1 ? $"{nickel} nickels" : "";

            return output;
        }

        /// <summary>
        /// Class method, use to display error to the screen.
        /// </summary>
        /// <param name="info">Information to show</param>
        /// <param name="refund">True if need to refund their money, otherwise false</param>
        private static void ShowError(string info, bool refund = false)
        {
            DisplayMachine(refund ? $"{info}\n\tYour money is returned. (Press any key to continue)" :
                                    $"\t\t\t{info} (Press any key to continue)");
            ReadKey();
        }

        /// <summary>
        /// Display a menu that visualizes a vending machine with name of each item, the price and quantity on hand.
        /// </summary>
        /// <param name="info">Information to show</param>
        /// <param name="info2">Optional, for multiline information</param>
        private static void DisplayMachine(string info, string info2 = null)
        {
            Clear();
            WriteLine("\n Vending Machine\n");
            WriteLine(" " + "".PadLeft(114, '~'));
            WriteLine($" ~{" ",112}~");

            for (var i = 0; i + 2 < items.Capacity; i++)
            {
                var set = new List<VendingItem> { items[i++], items[i++], items[i] };
                Write(" ~ ");

                set.ForEach(item => Write($" {item.Location}: {item.Item,-32}"));
                Write("~\n ~ ");

                set.ForEach(item => Write($" Price: {item.Price,-29:C}"));
                Write("~\n ~ ");

                set.ForEach(item => Write($" Quantity Left: {item.Quantity,-21}"));
                WriteLine($"~\n ~{" ",112}~");
            }
            WriteLine(" " + "".PadLeft(114, '~'));
            Write(info2 == null ? $"\n\t{info}: " : $"\n\t{info}\n\t{info2}: ");
        }

        /// <summary>
        /// Thid method manage the process to verify selection after inserted valid money
        /// </summary>
        private void GetSelection()
        {
            // Ask the user to make selection and show how much they've entered in the machine.
            DisplayMachine($"You have inserted ${input}. Please make your selection");
            picked = ReadLine()?.ToLower();

            // Verify if user's input is valid.
            if (picked != null && items.Exists(item => item.Location.ToLower() == picked))
            {
                itemPicked = items.Find(item => item.Location.ToLower() == picked);

                // Verify if user inserted enough money for the purchase.
                if (itemPicked.Price < input)
                {
                    // Verify if item is available for purchase.
                    if (itemPicked.ReduceInventory())
                    {
                        // Purchase success.
                        DisplayMachine($"Vending {itemPicked}",
                                       $"Your change is {MakeChange(itemPicked, input)} (Press any key to continue)");
                        ReadKey();
                    }
                    else
                        // Failed: Show error if item is out of stock.
                        ShowError($"Your selected item: {itemPicked} is not available.", true);
                }
                else
                    // Failed: Show error if the money inserted is not enough for the item.
                    ShowError($"Your selected item: {itemPicked} is more than the money you inserted.", true);
            }
            else
                // Failed: Show error if item doesn't exist.
                ShowError("Invalid entry . . .", true);
        }

        /// <summary>
        /// This method run the initial process and looping process and wait for user to insert money to machine.
        /// </summary>
        private void Run()
        {
            do
            {
                // Ask the user how much they are putting in the machine; only take paper money in the
                // following denominations: 1s, 2s, and 5s. Zero to end.
                DisplayMachine("Bill Inserted ($1, $2, $5, or 0 to end)");
                if (int.TryParse(ReadLine(), out input) &&
                    (input == 0 || input == 1 || input == 2 || input == 5))
                {
                    if (input != 0)
                        GetSelection();
                    else
                        break;
                }
                else
                {
                    // Failed: Show error if can't recognize user's input.
                    ShowError("Invalid input");
                }
            }
            while (true);
            Clear();
            Write("\n\tShutting down . . . (Press any key to end): ");
            ReadKey();
        }

        /// <summary>
        /// Instantiate the machine and run
        /// </summary>
        public static void Main()
        {
            new Program().FillMachine().Run();
        }
    }
}