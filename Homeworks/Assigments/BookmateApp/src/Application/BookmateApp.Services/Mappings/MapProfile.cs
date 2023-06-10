using AutoMapper;
using BookmateApp.DTOs.Requests;
using BookmateApp.DTOs.Responses;
using BookmateApp.Entities;
using Microsoft.Data.SqlClient;

namespace BookmateApp.Services.Mappings;

public class MapProfile : Profile
{
    public MapProfile()
    {
        // For Queries
        // Author
        CreateMap<Author, AuthorDisplayResponse>()
            .ForMember(
                dest => dest.FullName,
                opt => opt.MapFrom(src => $"{src.Firstname} {src.Lastname}"))
            .ForMember(
                dest => dest.Books, 
                opt => opt.MapFrom(src => src.Books!.Select(books => books.Title))
            );  
        // Book
        CreateMap<Book, BookDisplayResponse>()
            .ForMember(
                dest => dest.AuthorName,
                opt => opt.MapFrom(src => $"{src.Author!.Firstname} {src.Author.Lastname}"))
            .ForMember(
                dest => dest.Genre,
                opt => opt.MapFrom(src => $"{src.Genre!.Name}")
            )
            .ReverseMap();
        // Genre
        CreateMap<Genre, GenreDisplayResponse>();

        // Library
        CreateMap<Library, LibraryDisplayResponse>()
            .ForMember(
                dest => dest.Books,
                opt => opt.MapFrom(src => src.BooksLibrary!.Select(bookLibrary => bookLibrary.Book!.Title))
            );

        // For Commands
        // Author
        CreateMap<UpdateAuthorRequest, Author>();
        CreateMap<CreateAuthorRequest, Author>();

        // Book
        CreateMap<CreateBookRequest, Book>();
        CreateMap<UpdateBookRequest, Book>();

        // Genre
        CreateMap<CreateGenreRequest, Genre>();

        // Library
        CreateMap<CreateLibraryRequest, Library>();
        CreateMap<UpdateLibraryRequest, Library>();
    }
}