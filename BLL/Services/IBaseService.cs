using BLL.ResponsePattern;
using DTO.Abstract;
using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IBaseService<T, TDto> where T : class, IEntity where TDto : class, IDto
    {
        Response Insert(TDto dto);
        Response Update(TDto dto);
        Response Delete(TDto dto);
        Response<TDto> Get(int id);
        Response<IEnumerable<TDto>> GetAll();
    }
}
