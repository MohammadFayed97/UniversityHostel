namespace Faculties.Mappers;

public class DocumentMapper : Profile
{
    public DocumentMapper()
    {
        CreateMap<Document, DocumentViewModel>().ReverseMap();
      //  CreateMap<ApplicationDocument, DocumentAttachmentViewModel>().ReverseMap();
    }
}
