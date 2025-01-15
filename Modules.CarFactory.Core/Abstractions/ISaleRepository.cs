using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.Core.Abstractions
{
    public interface ISaleRepository
    {
        Dictionary<string, decimal> GetPercentForModels();

        decimal GetTotalVolume(int? distributionId = null);

        Sale Save(Sale sale);
    }
}