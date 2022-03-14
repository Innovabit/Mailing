namespace Innovabit.Mailing.Core.Application.Contracts.Providers
{
    public interface IProviderFactory
    {
        IMailingProvider CreateProvider(string providerName);
    }
}
