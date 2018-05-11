using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree.Domain
{
    public class AbpTreeEntity<T> : Entity<Guid>
    {
        public Guid? ParentId { get; set; }
        public string NodeName { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 深度
        /// </summary>
        public int Depth { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sorted { get; set; }
        public virtual IList<T> Child { get; set; }
    }
}
