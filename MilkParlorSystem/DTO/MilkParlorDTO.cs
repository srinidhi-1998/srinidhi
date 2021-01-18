using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilkParlorSystem.DTO
{
    public class MilkParlorDTO
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public int AreaId { get; set; }
        public string AreaName { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public int InchargerId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }

        public int Amount { get; set; }
        public int MilkParlorId { get; set; }
        public int Qty { get; set; }
        public int OrderId { get; set; }

        public string Status { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}