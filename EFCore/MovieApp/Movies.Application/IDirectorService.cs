using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application
{
    public interface IDirectorService
    {
        Task<IEnumerable<DirectorListResponse>> GetDirectorsAsync();
        Task<int> CreateNewDirectorAsync(CreateDirectorRequest request);
        Task<SingleDirectorResponse> GetDiroctorById(int id);
        Task<bool> UpdateDirectorAsync(UpdateDirectorRequest request);
    }
}
