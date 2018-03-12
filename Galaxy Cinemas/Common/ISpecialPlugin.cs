using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Business_Objects;

namespace Common
{
    public interface ISpecialPlugin
    {
        bool CalculateSpecial(Booking booking, ref string specialName, ref decimal specialPrice);


    }
}
