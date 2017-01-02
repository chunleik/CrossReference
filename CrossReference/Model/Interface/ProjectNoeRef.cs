using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Interface
{
    public abstract class ProjectNoeRef : ICrossReference
    {
        public abstract IDictionary<RefModel, ObjMetadata> MetadataDic { get; set; }

        public abstract bool Replace(IList<RefModel> objRefInfos);

        public abstract IList<RefModel> Search();
    }
}
