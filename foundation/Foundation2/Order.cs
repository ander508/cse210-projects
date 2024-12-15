public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(List<Product> products, Customer customer)
        {
            this.products = products;
            this.customer = customer;
        }

        // Method to calculate the total cost of the order
        public double GetTotalPrice()
        {
            double totalCost = 0;

            foreach (var product in products)
            {
                totalCost += product.GetTotalCost();
            }

            // Add the shipping cost based on the customer's location
            double shippingCost = customer.IsInUSA() ? 5.0 : 35.0;
            totalCost += shippingCost;

            return totalCost;
        }

        // Method to return the packing label for the order
        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (var product in products)
            {
                packingLabel += product.GetPackingLabel() + "\n";
            }

            return packingLabel;
        }

        // Method to return the shipping label for the order
        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{customer.GetShippingLabel()}";
        }
    }
