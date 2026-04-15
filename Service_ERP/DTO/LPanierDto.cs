using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LPanierDto : IMapFrom<LPanier>
{
    public int IdPan { get; set; }

    public int IdArt { get; set; }

    public int? Quantite { get; set; }

    public DateTime? DateAjout { get; set; }

    public virtual Article IdArtNavigation { get; set; }

    public virtual PanierDto IdPanNavigation { get; set; }
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<LPanier, LPanierDto>().ReverseMap();

    }
}
