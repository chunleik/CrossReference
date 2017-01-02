using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Interface;

namespace Model
{
    public class ProjectRef
    {
        private static ProjectRef instance = new ProjectRef();

        public static ProjectRef GetInstance()
        {
            return instance;
        }

        private ProjectRef() { }

        internal Dictionary<string, ProjectNoeRef> nodeDictionary=new Dictionary<string, ProjectNoeRef>();

        public ProjectNoeRef this[string key]
        {
            get
            {
                if (nodeDictionary.ContainsKey(key))
                {
                    return nodeDictionary[key];
                }
                return null;
            }
            set
            {
                nodeDictionary[key] = value;
            }
        }

        public string[] NodeNames()
        {
            return nodeDictionary.Keys.ToArray<string>();
        }

    }
}
