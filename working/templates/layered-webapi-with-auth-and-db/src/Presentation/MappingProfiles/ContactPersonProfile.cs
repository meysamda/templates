using $safeprojectname$.Infrastructure.Data.DbContexts.Entities;
using $safeprojectname$.Presentation.Commands;
using AutoMapper;

namespace $safeprojectname$.Presentation.MappingProfiles
{
    public class ContactPersonProfile : Profile
    {
        public ContactPersonProfile()
        {
            CreateMap<CreateContactPersonCommand, ContactPerson>();
            CreateMap<UpdateContactPersonCommand, ContactPerson>();
        }
    }
}