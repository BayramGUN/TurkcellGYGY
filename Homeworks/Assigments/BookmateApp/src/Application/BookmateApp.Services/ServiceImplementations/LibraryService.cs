using BookmateApp.DTOs.Requests;
using BookmateApp.DTOs.Responses;
using BookmateApp.Services.ServiceInterfaces;

namespace BookmateApp.Services.ServiceImplementations;

public class LibraryService : ILibraryService
{
    private readonly ILibraryService _libraryService;

    public LibraryService(ILibraryService libraryService)
    {
        _libraryService = libraryService;
    }

    public Task CreateLibraryAsync(CreateLibraryRequest createLibraryRequest)
    {
        throw new NotImplementedException();
    }

    public Task DeleteLibraryAsync(Guid libraryId)
    {
        throw new NotImplementedException();
    }

    public Task<IList<LibraryDisplayResponse>> GetAllLibrariesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<LibraryDisplayResponse> GetLibraryByIdAsync(Guid libraryId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateLibraryAsync(UpdateLibraryRequest updateLibraryRequest)
    {
        throw new NotImplementedException();
    }
}