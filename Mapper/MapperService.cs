using AutoMapper;
using Financial.Application.Mapper;
using Financial_Client.Mapper.Interface;

namespace Financial_Client.Mapper
{
    public class MapperService : IMapperService
    {
        public IMapper GetMapper()
        {
            var config = new AutoMapper.MapperConfiguration(optinos =>
            {
                optinos.AddProfile(new ProtoToDto()); 
            });
            return config.CreateMapper();
        }
    }
}
