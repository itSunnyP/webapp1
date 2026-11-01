using System.Text;

namespace WinFormsApp1
{
    public class ProductItem
    {
        public ProductItem(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public string Name { get; }
        public string Category { get; }
        public decimal Price { get; }

        public override string ToString() => $"{Name}  ({Price:N0} บาท)";
    }

    public class OrderLine
    {
        public string Name { get; set; } = "";
        public string Detail { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public decimal Total => UnitPrice * Qty;
    }

    public class Order
    {
        public const string CouponCode = "COFFEE20";
        public const decimal CouponValue = 20;

        public int No { get; set; }
        public DateTime Time { get; set; }
        public string Staff { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string CustomerType { get; set; } = "ทั่วไป";
        public string ServiceType { get; set; } = "ทานที่ร้าน";
        public int TableNo { get; set; } = 1;
        public DateTime PickupTime { get; set; }
        public string Note { get; set; } = "";
        public List<OrderLine> Lines { get; set; } = new();
        public bool UsedCoupon { get; set; }
        public string PayMethod { get; set; } = "";
        public decimal Received { get; set; }

        public decimal Subtotal => Lines.Sum(line => line.Total);

        public decimal MemberDiscount => CustomerType switch
        {
            "สมาชิก" => Subtotal * 0.10m,
            "นิสิต" => Subtotal * 0.05m,
            _ => 0
        };

        public decimal CouponDiscount => UsedCoupon ? CouponValue : 0;
        public decimal Total => Math.Max(0, Subtotal - MemberDiscount - CouponDiscount);
        public decimal Change => Received - Total;
        public int ItemCount => Lines.Sum(line => line.Qty);
        public string NoText => No.ToString("D4");

        /// <summary>
        ///  รวมรายการเดียวกันเข้าด้วยกัน แทนการเพิ่มบรรทัดใหม่
        /// </summary>
        public void AddLine(OrderLine line)
        {
            OrderLine? same = Lines.Find(l => l.Name == line.Name && l.Detail == line.Detail);
            if (same != null)
                same.Qty += line.Qty;
            else
                Lines.Add(line);
        }

        public string BuildReceipt()
        {
            var text = new StringBuilder();
            text.AppendLine("ใบเสร็จรับเงิน");
            text.AppendLine($"เลขที่\t{NoText}");
            text.AppendLine($"วันที่\t{Time:dd/MM/yyyy HH:mm}");
            text.AppendLine($"พนักงาน\t{Staff}");
            text.AppendLine($"ลูกค้า\t{CustomerName} ({CustomerType})");
            text.AppendLine(ServiceType == "ทานที่ร้าน"
                ? $"รับสินค้า\tทานที่ร้าน โต๊ะ {TableNo}"
                : $"รับสินค้า\tกลับบ้าน เวลา {PickupTime:HH:mm} น.");
            if (Note.Length > 0)
                text.AppendLine($"หมายเหตุ\t{Note}");
            text.AppendLine(new string('-', 60));

            foreach (OrderLine line in Lines)
            {
                text.AppendLine($"{line.Name} x {line.Qty}\t{line.Total:N2}");
                if (line.Detail.Length > 0)
                    text.AppendLine($"   {line.Detail}");
            }

            text.AppendLine(new string('-', 60));
            text.AppendLine($"ยอดรวม\t{Subtotal:N2}");
            if (MemberDiscount > 0)
                text.AppendLine($"ส่วนลด{CustomerType}\t-{MemberDiscount:N2}");
            if (CouponDiscount > 0)
                text.AppendLine($"ส่วนลดคูปอง\t-{CouponDiscount:N2}");
            text.AppendLine($"ยอดสุทธิ\t{Total:N2}");
            text.AppendLine($"ชำระโดย\t{PayMethod}");
            if (PayMethod == "เงินสด")
            {
                text.AppendLine($"รับเงิน\t{Received:N2}");
                text.AppendLine($"เงินทอน\t{Change:N2}");
            }
            return text.ToString();
        }
    }

    /// <summary>
    ///  ข้อมูลกลางที่ทุกฟอร์มใช้ร่วมกัน เก็บในหน่วยความจำ จะหายเมื่อปิดโปรแกรม
    /// </summary>
    public static class AppData
    {
        public static readonly List<ProductItem> Drinks = new()
        {
            new("เอสเพรสโซ", "เครื่องดื่ม", 45),
            new("อเมริกาโน", "เครื่องดื่ม", 50),
            new("ลาเต้", "เครื่องดื่ม", 55),
            new("คาปูชิโน", "เครื่องดื่ม", 55),
            new("มอคค่า", "เครื่องดื่ม", 60),
            new("มัทฉะลาเต้", "เครื่องดื่ม", 60),
            new("ชาไทย", "เครื่องดื่ม", 50),
            new("โกโก้", "เครื่องดื่ม", 55),
        };

        public static readonly List<ProductItem> Bakery = new()
        {
            new("ช็อกโกแลตเค้ก", "เค้ก", 85),
            new("เค้กมะพร้าวอ่อน", "เค้ก", 90),
            new("ชีสเค้ก", "เค้ก", 95),
            new("ครัวซองต์เนย", "ครัวซองต์", 65),
            new("ครัวซองต์อัลมอนด์", "ครัวซองต์", 75),
            new("ครัวซองต์แฮมชีส", "ครัวซองต์", 80),
            new("คุกกี้ช็อกชิป", "คุกกี้", 35),
            new("คุกกี้ข้าวโอ๊ต", "คุกกี้", 35),
            new("มาการอง", "คุกกี้", 45),
        };

        public static List<Order> Orders { get; } = new();
        public static Order Current { get; private set; } = new();
        public static Order? LastOrder { get; private set; }
        public static string StaffName { get; set; } = "";

        public static void StartNewOrder() => Current = new Order();

        public static void CompleteCurrentOrder()
        {
            Current.No = Orders.Count == 0 ? 1 : Orders.Max(order => order.No) + 1;
            Current.Time = DateTime.Now;
            Current.Staff = StaffName;
            Orders.Add(Current);
            LastOrder = Current;
            StartNewOrder();
        }
    }
}
