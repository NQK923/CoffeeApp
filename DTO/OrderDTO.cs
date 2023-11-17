using System;

namespace DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public int PointUse { get; set; }
        public bool Status { get; set; }
        public int Total { get; set; }
    }
}
