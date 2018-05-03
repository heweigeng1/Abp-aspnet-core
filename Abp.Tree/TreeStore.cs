using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbpTree
{
    public abstract class TreeStore<AbpTree> where AbpTree:AbpTreeEntity
    {
        private IRepository<AbpTree, Guid> _repository;
        protected TreeStore(IRepository<AbpTree, Guid> repository) { _repository = repository; }
        public virtual IQueryable<AbpTree> Trees { get; }
    }
}
