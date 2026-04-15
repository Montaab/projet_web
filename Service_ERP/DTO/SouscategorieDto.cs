using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class SouscategorieDto : IMapFrom<Souscategorie>
{
    public int IdScat { get; set; }

    public string CodeScat { get; set; }

    public string Libelle { get; set; }

    public string Description { get; set; }

    public int? IdCat { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    public virtual CategorieDto IdCatNavigation { get; set; }
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Souscategorie, SouscategorieDto>().ReverseMap();

    }
}
