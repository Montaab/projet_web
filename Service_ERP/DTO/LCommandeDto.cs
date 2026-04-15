using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LCommandeDto : IMapFrom<LCommande>
{
    public int IdCom { get; set; }

    public int IdArt { get; set; }

    public int? Quantite { get; set; }

    public decimal? PrixAchat { get; set; }

    public decimal? Remise { get; set; }

    public virtual Article IdArtNavigation { get; set; }

    public virtual CommandeDto IdComNavigation { get; set; }
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<LCommande, LCommandeDto>().ReverseMap();

    }
}
