using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;

namespace Dto
{
   public class PreferabilityDayDto
    {
        public int DayPreferId { get; set; }
        public Nullable<int> IdDay { get; set; }
        public Nullable<int> LevelPriority { get; set; }
        public Nullable<int> IdParent { get; set; }
        public preferabilityDay DalToDto()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PreferabilityDayDto, preferabilityDay>());
            var mapper = new Mapper(config);
            return mapper.Map<preferabilityDay>(this);
        }
        public PreferabilityDayDto DtoToDal(preferabilityDay p)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<preferabilityDay, PreferabilityDayDto>());
            var mapper = new Mapper(config);
            return mapper.Map<PreferabilityDayDto>(p);
        }
    }
}
