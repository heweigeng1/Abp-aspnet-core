using Abp.Domain.Services;
using AbpTree.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree.Services
{
    public interface ITreeService 
    {
        List<ITreeEntity> GetList();
        ITreeEntity Get(Guid id);
    }
}
