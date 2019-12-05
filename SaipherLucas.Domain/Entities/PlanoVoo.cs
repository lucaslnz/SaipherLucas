using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SaipherLucas.Domain.Entities.Base;
using SaipherLucas.Domain.Resources;
using System;

namespace SaipherLucas.Domain.Entities
{
    public class PlanoVoo : BaseEntity
    {
        public Guid IdAeroportoOrigem { get; private set; }
        public Guid IdAeroportoDestino { get; private set; }
        public Guid IdAeronave { get; private set; }
        public Guid IdVoo { get; private set; }

        protected PlanoVoo()
        {

        }

        public PlanoVoo(Guid idAeroportoOrigem, Guid idAeroportoDestino, Guid idAeronave, Guid idVoo)
        {
            IdAeroportoOrigem = ValidarGuid(idAeroportoOrigem, "Id do aeroporto de origem");
            IdAeroportoDestino = ValidarGuid(idAeroportoDestino, "Id do aeroporto de destino");
            IdAeronave = ValidarGuid(idAeronave, "Id da aeronave");
            IdVoo = ValidarGuid(idVoo, "Id do voo");
        }

        public void AlterarPlanoVoo(Guid idAeroportoOrigem, Guid idAeroportoDestino, Guid idAeronave, Guid idVoo)
        {
            IdAeroportoOrigem = ValidarGuid(idAeroportoOrigem, "Id do aeroporto de origem");
            IdAeroportoDestino = ValidarGuid(idAeroportoDestino, "Id do aeroporto de destino");
            IdAeronave = ValidarGuid(idAeronave, "Id da aeronave");
            IdVoo = ValidarGuid(idVoo, "Id do voo");
        }

        Guid ValidarGuid(Guid id, string nomePropriedade)
        {
            if(Convert.ToString(id) == "00000000-0000-0000-0000-000000000000")
            {
                AddNotification(nomePropriedade, Message.X0_INVALIDO.ToFormat(nomePropriedade));
                return id;
            }
            else 
            {
                if (Guid.TryParseExact(Convert.ToString(id), "D", out var guidValido))
                {
                    return guidValido;
                }
                else
                {
                    AddNotification(nomePropriedade, Message.X0_INVALIDO.ToFormat(nomePropriedade));
                    return new Guid("00000000-0000-0000-0000-000000000000");
                }
            }
        }
    }
}
