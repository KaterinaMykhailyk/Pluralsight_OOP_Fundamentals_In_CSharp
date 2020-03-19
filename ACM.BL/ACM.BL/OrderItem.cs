using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        // Retrieve one order item
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        // Retrieve order items list
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0 ||
                ProductId <= 0 ||
                PurchasePrice == null)
                isValid = false;

            return isValid;
        }
    }
}
