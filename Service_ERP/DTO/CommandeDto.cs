using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class CommandeDto : IMapFrom<Commande>
{
    public int IdCom { get; set; }

    public DateOnly? DateCom { get; set; }

    public string Statut { get; set; }

    public decimal? Total { get; set; }

    public string ModePaiement { get; set; }

    public int? IdClt { get; set; }

    public virtual ICollection<FactureDto> Factures { get; set; } = new List<FactureDto>();

    public virtual ClientDto IdCltNavigation { get; set; }

    public virtual ICollection<LCommandeDto> LCommandes { get; set; } = new List<LCommandeDto>();
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Commande, CommandeDto>().ReverseMap();

    }
}
