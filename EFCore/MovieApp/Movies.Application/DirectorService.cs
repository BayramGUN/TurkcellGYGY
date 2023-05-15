using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Movies.Application;

public class DirectorService : IDirectorService
{

    private readonly IDirectorRepository directorRepository;

    public DirectorService(IDirectorRepository directorRepository)
    {
        this.directorRepository = directorRepository;
    }

    public async Task<int> CreateNewDirectorAsync(CreateDirectorRequest request)
    {
        var director = new Director
        {
            Info = request.Info,
            Name = request.Name,
            LastName = request.Lastname
        };
        await directorRepository.CreateAsync(director);
        return director.Id;
    }


    public async Task<IEnumerable<DirectorListResponse>> GetDirectorsAsync()
    {
        var directors = await directorRepository.GetAllAsync();
        var responses = directors.Select(director => new DirectorListResponse
        {
            Info = director.Info,
            Name = director.Name,
            LastName = director.LastName
        });
       
        return responses;
    }

    public async Task<SingleDirectorResponse> GetDiroctorById(int id)
    {
        var director = await directorRepository.GetByIdAsync(id);
        if (director is null)
            throw new ArgumentNullException("Director is null");
        var response = new SingleDirectorResponse
        {
            Name = director.Name,
            Lastname = director.LastName,
            Info = director.Info
        };
        return response;
    }

    public async Task<bool> UpdateDirectorAsync(UpdateDirectorRequest request)
    {
        var director = await directorRepository.GetByIdAsync(request.Id);
        if (director is null)
        {
            return false;
            throw new ArgumentNullException("director not found");
        }
        director.Id = request.Id;
        director.Name = request.Name;
        director.LastName = request.Lastname;
        director.Info = request.Info;
        await directorRepository.UpdateAsync(director);

        return true;
    }
}
