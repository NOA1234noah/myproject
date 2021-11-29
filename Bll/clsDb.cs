using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bll
{
   public class clsDb
    {

        StudentsCarPoolEntities1 db = new StudentsCarPoolEntities1();
        public RequestResult GetAllChildren()
        {
            List<ChildDto> l = new List<ChildDto>();
            foreach (var item in db.Children.ToList())
            {
                l.Add(ChildDto.DalToDto(item));
            }
            return new RequestResult() { Data = l };
        }
        public RequestResult GetAllParents()
        {
            List<ParentDto> l = new List<ParentDto>();
            foreach (var item in db.Parents.ToList())
            {
                l.Add(ParentDto.DalToDto(item));
            }
            return new RequestResult() { Data = l };
        }
    }
}
