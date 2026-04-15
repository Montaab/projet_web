using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class FactureDto : IMapFrom<Facture>
{
    public int IdFact { get; set; }

    public DateOnly? DateFact { get; set; }

    public decimal? MontantTotal { get; set; }

    public string ModePaiement { get; set; }

    public int? IdCom { get; set; }

    public virtual CommandeDto IdComNavigation { get; set; }

    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Facture, FactureDto>().ReverseMap();

    }
}
