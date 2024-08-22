using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<Customer> _customers;
        private List<MenuItem> _menu;
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }
        public Restaurant()
        {
            _customers = new List<Customer>();
            _menu = new List<MenuItem>();
        }
        public MenuItem GetMenuItem(int index)
        {
            if (index < 0 || index >= _menu.Count)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            return _menu[index];
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            _menu.Add(menuItem);
        }

        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach (MenuItem menuItem in _menu)
            {
                Console.WriteLine(menuItem.ToString());
            }
        }

        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");
            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: ${order.GetTotal()}");
                foreach (MenuItem menuItem in order.Items)
                {
                    Console.WriteLine(" " + menuItem.ToString());
                }
            }
        }
    }
}
