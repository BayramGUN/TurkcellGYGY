using AutoMapper;
using CourseApp.DTOs.Responses;
using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services.Extensions
{
    public static class MappingExtensions
    {
        public static T ConvertToDto<T>(this IEnumerable<Course> value, IMapper mapper)
        {
            return mapper.Map<T>(value);
        }
        public static T ConvertToDto<T>(this IEnumerable<Category> value, IMapper mapper)
        {
            return mapper.Map<T>(value);
        }
        public static Tout ConverTo<Tin, Tout>(this Tin value, IMapper mapper)
        {
            return mapper.Map<Tout>(value);
        }
        public static IEnumerable<CourseDisplayResponse> ConverToDisplayResponses(this IEnumerable<Course> courses, IMapper mapper)
        {
            return mapper.Map<IEnumerable<CourseDisplayResponse>>(courses);
        }

    }
}
