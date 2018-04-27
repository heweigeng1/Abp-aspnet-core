using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;

namespace AbpTree.Services
{
    public class TreeService<TPrimaryKey> : DomainService, ITreeService<TPrimaryKey>
    {
        private readonly IRepository<ITreeEntity<TPrimaryKey>,TPrimaryKey> treeRepository;
        public TreeService() {

        }
        public ITreeEntity<TPrimaryKey> Get(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public List<ITreeEntity<TPrimaryKey>> GetList()
        {
            throw new NotImplementedException();
        }

        public ITreeEntity<TPrimaryKey> InitTree()
        {
            throw new NotImplementedException();
        }
    }
}
