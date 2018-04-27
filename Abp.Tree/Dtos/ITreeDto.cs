using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree.Dtos
{
    interface ITreeDto<TPrimaryKey> : ITreeEntity<TPrimaryKey>
    {
        List<ITreeDto<TPrimaryKey>> Child { get; set; }
    }
}
