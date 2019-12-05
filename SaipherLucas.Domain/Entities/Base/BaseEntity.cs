using prmToolkit.NotificationPattern;
using System;

namespace SaipherLucas.Domain.Entities.Base
{
    public class BaseEntity : Notifiable
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
