using System;

namespace College_Fest_Event_Handling
{
    public delegate void FestEventHandler(int visitors);

    public class College
    {
        public event FestEventHandler CollegeFest;

        public void OrganizeFest(int visitors)
        {
            CollegeFest?.Invoke(visitors);
        }
    }
}
