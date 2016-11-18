using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Transformers
{
    public static class TagTransformer
    {
        public static string Transform(string tag)
        {
            if (!tag.StartsWith("#"))
            {
                tag = "#" + tag;
            }
            if (tag.Contains(" "))
            {
                tag = tag.Replace(" ", "");
            }
            if (tag.Length > 20)
            {
                tag = tag.Substring(0, 20);
            }
            return tag;
        }
    }
}
