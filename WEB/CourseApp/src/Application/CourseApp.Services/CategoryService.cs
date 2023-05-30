using AutoMapper;
using CourseApp.DTOs.Responses;
using CourseApp.Entities;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDisplayResponse> GetCategoryDisplayResponses()
        {
            var categories = _categoryRepository.GetAll();
            var responses = categories!.ConvertToDto<IEnumerable<CategoryDisplayResponse>>(_mapper);
            // var responsesAlternate = courses!.ConverToDisplayResponses(_mapper);
           // var responsesAlternateTwo = courses!.ConverTo<Course, CourseDisplayResponse>(_mapper);
            return responses;
        }
    }
}
