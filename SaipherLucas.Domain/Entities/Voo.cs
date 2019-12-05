using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SaipherLucas.Domain.Entities.Base;
using SaipherLucas.Domain.Resources;
using System;

namespace SaipherLucas.Domain.Entities
{
    public class Voo : BaseEntity
    {
        public string Numero { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime Horario { get; private set; }

        protected Voo()
        {
        }

        public Voo(string numero, DateTime data, DateTime horario)
        {
            Numero = numero;
            Data = data;
            Horario = horario;

            ValidarVoo();
        }

        public void AlterarVoo(string numero, DateTime data, DateTime horario)
        {
            Numero = numero;
            Data = data;
            Horario = horario;

            ValidarVoo();
        }

        void ValidarVoo()
        {
            new AddNotifications<Voo>(this)
                .IfNullOrInvalidLength(x => x.Numero, 6, 15, Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Número do voo", "6", "15"))
                .IfNull(x => x.Data, Message.X0_E_OBRIGATORIA)
                .IfNull(x => x.Horario, Message.X0_E_OBRIGATORIO);
        }
    }
}
