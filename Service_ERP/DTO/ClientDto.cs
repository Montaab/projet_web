using Service.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ClientDto : IMapFrom<Client>
{
    public int IdClt { get; set; }

    public string Nom { get; set; }

    public string Prenom { get; set; }

    public string Adresse { get; set; }

    public string Email { get; set; }

    public string Telephone { get; set; }

    public DateTime? DateInscription { get; set; }

    public virtual ICollection<CommandeDto> Commandes { get; set; } = new List<CommandeDto>();
    public void Mapping(AutoMapper.Profile profile)
    {
        profile.CreateMap<Client, ClientDto>().ReverseMap();

    }
}
