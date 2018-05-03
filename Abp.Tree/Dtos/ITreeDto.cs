using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree.Dtos
{
    interface ITreeDto 
    {
        List<ITreeDto> Child { get; set; }
    }
}
