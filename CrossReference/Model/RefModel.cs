using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class RefModel
    {
        private List<RefModel> children;

        public List<RefModel> Children
        {
            get { return children??(children=new List<RefModel>()); }
            set { children = value; }
        }

    }
}
