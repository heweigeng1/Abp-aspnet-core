using Abp.Domain.Services;
using AbpTree.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree.Services
{
    interface ITreeService<TPrimaryKey>: IDomainService
    {
        List<ITreeEntity<TPrimaryKey>> GetList();
        ITreeEntity<TPrimaryKey> Get(TPrimaryKey id);
        ITreeEntity<TPrimaryKey>  InitTree();

    }
}
