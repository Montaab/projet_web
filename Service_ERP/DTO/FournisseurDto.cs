using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class FournisseurDto : IMapFrom<Fournisseur>
{
    public int IdFour { get; set; }

    public string NomSociete { get; set; }

    public string Tel { get; set; }

    public string Email { get; set; }

    public string Adresse { get; set; }

    public string Ville { get; set; }

    public virtual ICollection<LFournisseurDto> LFournisseurs { get; set; } = new List<LFournisseurDto>();
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Fournisseur, FournisseurDto>().ReverseMap();

    }
}
