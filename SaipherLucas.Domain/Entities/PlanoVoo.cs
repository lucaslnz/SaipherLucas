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
            IdAeroportoOrigem = idAeroportoOrigem;
            IdAeroportoDestino = idAeroportoDestino;
            IdAeronave = idAeronave;
            IdVoo = idVoo;

            ValidarPlanoVoo();
        }

        public void AlterarPlanoVoo(Guid idAeroportoOrigem, Guid idAeroportoDestino, Guid idAeronave, Guid idVoo)
        {
            IdAeroportoOrigem = idAeroportoOrigem;
            IdAeroportoDestino = idAeroportoDestino;
            IdAeronave = idAeronave;
            IdVoo = idVoo;

            ValidarPlanoVoo();
        }

        void ValidarPlanoVoo()
        {
            new AddNotifications<PlanoVoo>(this)
                .IfNullOrEmpty(x => Convert.ToString(x.IdAeroportoOrigem), Message.X0_E_OBRIGATORIO.ToFormat("Id do aeroporto de origem"))
                .IfNullOrEmpty(x => Convert.ToString(x.IdAeroportoDestino), Message.X0_E_OBRIGATORIO.ToFormat("Id do aeroporto de destino"))
                .IfNullOrEmpty(x => Convert.ToString(x.IdAeronave), Message.X0_E_OBRIGATORIO.ToFormat("Id da aeronave"))
                .IfNullOrEmpty(x => Convert.ToString(x.IdVoo), Message.X0_E_OBRIGATORIO.ToFormat("Id do voo"));
            //.IfNull(x => x.IdAeroportoOrigem, Message.X0_E_OBRIGATORIO.ToFormat("Id do aeroporto de origem"))
            //.IfNull(x => x.IdAeroportoDestino, Message.X0_E_OBRIGATORIO.ToFormat("Id do aeroporto de destino"))
            //.IfNull(x => x.IdAeronave, Message.X0_E_OBRIGATORIO.ToFormat("Id da aeronave"))
            //.IfNull(x => x.IdVoo, Message.X0_E_OBRIGATORIO.ToFormat("Id do voo"));
        }
    }
}
