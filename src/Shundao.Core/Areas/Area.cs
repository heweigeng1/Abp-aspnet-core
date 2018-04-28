using AbpTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public class Area : ITreeEntity<Guid>
    {
        public Guid ParentId { get; set; }
        public string NodeName { get; set; }
        public Guid Id { get; set; }

        public bool IsTransient()
        {
            return true;
        }
    }
}
