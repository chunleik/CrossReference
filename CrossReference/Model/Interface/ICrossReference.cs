using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Interface
{
    public interface ICrossReference
    {
        IList<RefModel> Search();

        bool Replace(IList<RefModel> objRefInfos);
    }
}
