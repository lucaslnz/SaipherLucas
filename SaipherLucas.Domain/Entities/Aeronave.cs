using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SaipherLucas.Domain.Entities.Base;
using SaipherLucas.Domain.Resources;

namespace SaipherLucas.Domain.Entities
{
    public class Aeronave : BaseEntity
    {
        public string Matricula { get; private set; }
        public string Tipo { get; private set; }

        protected Aeronave() 
        { 
        }

        public Aeronave(string tipo, string matricula)
        {
            Tipo = tipo;
            Matricula = matricula;

            ValidarAeronave();
        }

        public void AlterarAeronave(string tipo, string matricula)
        {
            Tipo = tipo;
            Matricula = matricula;

            ValidarAeronave();
        }

        void ValidarAeronave()
        {
            new AddNotifications<Aeronave>(this)
                .IfNullOrInvalidLength(x => x.Tipo, 4, 20, Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Tipo da aeronave", "4", "20"))
                .IfNullOrInvalidLength(x => x.Matricula, 4, 20, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Matrícula da aeronave", "4", "20"));
        }
    }
}
