using AutoMapper;
using CourseApp.DTOs.Responses;
using CourseApp.Entities;


namespace CourseApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Course, CourseDisplayResponse>();
            CreateMap<Category, CategoryDisplayResponse>();
        }
    }
}
