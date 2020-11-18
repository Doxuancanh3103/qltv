using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.common
{
    class DateUtils
    {

        public static DateTime parse(String date,String pattern)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(date, pattern, provider);
        }
    }
}
