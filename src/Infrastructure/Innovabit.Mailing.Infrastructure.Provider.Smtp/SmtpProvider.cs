using Innovabit.Mailing.Core.Application.Contracts.Providers;

namespace Innovabit.Mailing.Infrastructure.Provider.Smtp
{
    public class SmtpProvider : IMailingProvider
    {
        public string Name => "SMTP";
    }
}
