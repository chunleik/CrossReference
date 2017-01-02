using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Interface
{
    public class ObjMetadata
    {
        public bool IsObj { get; }

        public string Dispaly { get; set; }

        public string Type { get; set; }

        public string ScriptPath { get; set; }

        public List<Tuple<string,string>> MetadataInfo { get; set; }

        public string Script { get; set; }
    }
}
