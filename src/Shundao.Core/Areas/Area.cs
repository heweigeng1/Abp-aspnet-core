using AbpTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public class Area : ITreeEntity
    {
        public string Code { get; set; }
        public Guid Id { get; set; }
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

        public bool IsTransient()
        {
            throw new NotImplementedException();
        }
    }
}
