using System;

namespace OrderManagement
{
    [Serializable]
    public class OrderDetail
    {
        private int id;
        private Good good;
        
        private int num;
        public OrderDetail() { }

        public Good Good { get; }
        public int Id { get; }
        
        
        
        public int Num
        {
            get { return num; }
            set
            {
                if (num < 0) { throw new ArgumentException("invalid number"); }
                else num = value;
            }
        }
        
        public double Amount { get { return good.Price*num; } }

        public OrderDetail(int id, Good good, int num)
        {
            this.id = id;
            this.good = good;
            
            this.num = num;
        }

        

        public override bool Equals(object? obj)
        {
            return obj is OrderDetail detail &&
                   detail == null && detail.id == id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string? ToString()
        {
            String s = "";
            s += String.Format("id:{0} good:{1} num:{2}", id, good, num);
                return s;
        
        }

        
    }
}