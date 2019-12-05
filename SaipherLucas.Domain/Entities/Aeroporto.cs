using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SaipherLucas.Domain.Entities.Base;
using SaipherLucas.Domain.Resources;

namespace SaipherLucas.Domain.Entities
{
    public class Aeroporto : BaseEntity
    {
        public string Sigla { get; private set; }
        public string Nome { get; private set; }

        protected Aeroporto()
        {
        }

        public Aeroporto(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;

            ValidarAeroporto();
        }

        public void AlterarAeroporto(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;

            ValidarAeroporto();
        }

        void ValidarAeroporto()
        {
            new AddNotifications<Aeroporto>(this)
                .IfNullOrInvalidLength(x => x.Sigla, 3, 40, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Sigla do aeroporto", "3", "40"))
                .IfNullOrInvalidLength(x => x.Nome, 4, 70, Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome do aeroporto", "4", "70"));
        }
    }
}
