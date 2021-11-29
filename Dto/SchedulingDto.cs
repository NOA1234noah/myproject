using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;


namespace Dto
{
   public class SchedulingDto
    {
        public int SchedulingId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> ChildId { get; set; }
        public Nullable<int> DayId { get; set; }
        public Scheduling DalToDto()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SchedulingDto, Scheduling>());
            var mapper = new Mapper(config);
            return mapper.Map<Scheduling>(this);
        }
        public SchedulingDto DtoToDal(Scheduling p)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Scheduling, SchedulingDto>());
            var mapper = new Mapper(config);
            return mapper.Map<SchedulingDto>(p);
        }
    }
}
