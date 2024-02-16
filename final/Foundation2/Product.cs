class Product
    {
        private string productId;
        private string name;
        private double price;
        private int quantity;

        public Product(string productId, string name, double price, int quantity)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        // Getters and setters

        public string GetProductId()
        {
            return productId;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }
