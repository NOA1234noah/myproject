using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;

namespace Dto
{
   public class ParentDto
    {
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Destenition { get; set; }
        public int NumEmptyPlace { get; set; }
        public Nullable<int> KodPreferDays { get; set; }
        public string Source { get; set; }
        public Nullable<int> ChildId { get; set; }
        public Parent DtoToDal()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ParentDto, Parent>());
            var mapper = new Mapper(config);
            return mapper.Map<Parent>(this);
        }
        public static ParentDto DalToDto(Parent p)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Parent, ParentDto>());
            var mapper = new Mapper(config);
            return mapper.Map<ParentDto>(p);
        }
    }
}
