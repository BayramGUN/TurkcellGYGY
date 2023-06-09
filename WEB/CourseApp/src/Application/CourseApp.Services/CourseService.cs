﻿using AutoMapper;
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
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public CourseDisplayResponse GetCourseDisplayResponse(int id)
        {
            var course = _courseRepository.Get(id);
            return _mapper.Map<CourseDisplayResponse>(course);
        }

        public IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses()
        {
            var courses = _courseRepository.GetAll();
            var responses = courses!.ConvertToDto<IEnumerable<CourseDisplayResponse>>(_mapper);
            // var responsesAlternate = courses!.ConverToDisplayResponses(_mapper);
           // var responsesAlternateTwo = courses!.ConverTo<Course, CourseDisplayResponse>(_mapper);
            return responses;
        }

        public IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId)
        {
            var courses = _courseRepository.GetCoursesByCategory(categoryId);
            return courses.ConvertToDto<IEnumerable<CourseDisplayResponse>>(_mapper);
        }
    }
}
