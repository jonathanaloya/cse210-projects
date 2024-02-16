class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;

            foreach (Product product in products)
            {
                totalPrice += product.GetPrice() * product.GetQuantity();
            }

            if (customer.IsInUSA())
            {
                totalPrice += 5; // Shipping cost for USA customers
            }
            else
            {
                totalPrice += 35; // Shipping cost for non-USA customers
            }

            return totalPrice;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";

            foreach (Product product in products)
            {
                packingLabel += "Name: " + product.GetName() + ", Product ID: " + product.GetProductId() + "\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string shippingLabel = "";

            shippingLabel += "Name: " + customer.GetName() + "\n";
            shippingLabel += "Address: " + customer.GetAddress().GetFullAddress();

            return shippingLabel;
        }
    }
