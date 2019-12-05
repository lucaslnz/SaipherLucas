using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using SaipherLucas.Domain.Resources;
using System;

namespace SaipherLucas.Domain.Services.Base
{
    public class ServiceBase : Notifiable
    {
        public bool VerificaRequest(Object request, string nomeRequest)
        {
            if (request == null) 
            {
                AddNotification(nomeRequest, Message.OBJETO_X0_E_OBRIGATORIO.ToFormat(nomeRequest));
                return false;
            }
            return true;
        }
    }
}
