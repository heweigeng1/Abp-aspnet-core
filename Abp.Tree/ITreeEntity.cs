using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree
{
    public interface ITreeEntity : IEntity<Guid>
    {
        Guid? ParentId { get; set; }
        string NodeName { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        string Path { get; set; }
        /// <summary>
        /// 深度
        /// </summary>
        int Depth { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        int Sorted { get; set; }
    }
}
