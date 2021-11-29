using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;
namespace Dto
{
   public class ChildDto
    {
        public int ChildId { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Destenition { get; set; }
        public Nullable<int> DestinationX { get; set; }
        public Nullable<int> DestinationY { get; set; }
        public  Child DtoToDal()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChildDto, Child>());
            var mapper = new Mapper(config);
            return mapper.Map<Child>(this);
        }
        public static ChildDto DalToDto(Child c)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Child, ChildDto>());
            var mapper = new Mapper(config);
            return mapper.Map<ChildDto>(c);
        }

    }
}
