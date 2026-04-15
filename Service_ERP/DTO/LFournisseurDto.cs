using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class LFournisseurDto : IMapFrom<LFournisseur>
{
    public int IdFour { get; set; }

    public int IdArt { get; set; }

    public int? DelaiLivraison { get; set; }

    public decimal? PrixFournisseur { get; set; }

    public virtual Article IdArtNavigation { get; set; }

    public virtual FournisseurDto IdFourNavigation { get; set; }
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<LFournisseur, LFournisseurDto>().ReverseMap();

    }
}
