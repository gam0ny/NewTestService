using BLL.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Services
{
    public interface IResultService
    {
        ResultEntity GetResultEntityById(int id);
        IEnumerable<ResultEntity> GetResultEntityByUserId(int userId);
        ResultEntity GetResultEntityByUserIdAndDate(int userId, DateTime date);
    }
}
