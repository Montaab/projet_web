using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class PanierDto : IMapFrom<Panier>
{
    public int IdPan { get; set; }

    public DateTime? DateCreation { get; set; }

    public int? IdClt { get; set; }

    public virtual ICollection<LPanierDto> LPaniers { get; set; } = new List<LPanierDto>();
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Panier, PanierDto>().ReverseMap();

    }
}
