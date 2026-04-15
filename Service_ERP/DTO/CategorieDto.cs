using AutoMapper;
using Core.Entities;
using Service.Common.Mappings;
using Service.DTO;

namespace Core.Entities;

public partial class CategorieDto : IMapFrom<Categorie>
{
    public int IdCat { get; set; }

    public string CodeCat { get; set; }

    public string Libelle { get; set; }

    public string Description { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<SouscategorieDto> Souscategories { get; set; } = new List<SouscategorieDto>();
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Categorie, CategorieDto>().ReverseMap();

    }

}
