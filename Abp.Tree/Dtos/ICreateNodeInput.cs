using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree.Dtos
{
     interface ICreateNodeInput<TPrimaryKey>
    {
        string NodeName { get; set; }
    }
}
