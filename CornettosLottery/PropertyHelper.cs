using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CornettosLottery
{
    public static class PropertyHelper
    {
        public static string PropertyFormatValue(this object xProperty,int number)
        {
            return xProperty.ToString().PadRight(number, ' ');
        }
    }
}
