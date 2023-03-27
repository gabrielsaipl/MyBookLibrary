using AutoMapper;

namespace Books.API.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile() 
        {
            CreateMap<Entities.Book, Models.BookDto>();
            CreateMap<Models.BookDto, Entities.Book >();
            CreateMap<Models.BookForUpdateDto, Entities.Book>();
            CreateMap<Entities.Book, Models.BookForUpdateDto >();
        }
    }
}
