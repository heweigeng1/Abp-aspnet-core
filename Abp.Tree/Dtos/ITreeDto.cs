using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree.Dtos
{
    interface ITreeDto : ITreeEntity
    {
        List<ITreeDto> Child { get; set; }
    }
}
