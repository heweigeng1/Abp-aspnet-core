using AbpTree.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public class Area : AbpTreeEntity<Area>
    {
        public string Code { get; set; }
    }
}
