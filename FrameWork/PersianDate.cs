using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FrameWork
{
  public   class PersianDate
    {
        public static string TopersianDate(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(t) + "/" + pc.GetMonth(t) + "/" + pc.GetDayOfMonth(t);
        }

    }
}
