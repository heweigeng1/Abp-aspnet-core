using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree
{
    public interface ITreeEntity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        TPrimaryKey ParentId { get; set; }
        string NodeName { get; set; }
    }
}
