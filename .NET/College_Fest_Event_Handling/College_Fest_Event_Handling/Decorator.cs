using System;

namespace College_Fest_Event_Handling
{
    public class Decorator
    {
        public string DecorationBill { get; private set; }

        public void OnCollegeFest(int visitors)
        {
            int total = 10000 + (visitors * 10);
            DecorationBill = $"Decoration Bill: ₹{total}";
        }
    }
}
