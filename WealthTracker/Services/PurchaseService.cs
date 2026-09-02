using WealthTracker.Repositories;

namespace WealthTracker.Services
{
    public class PurchaseService
    {
        private readonly IPurchaseRepository _repository;
        private readonly IAssetService _assetService;
        private readonly IBrapiService _brapiService;
        private readonly IPositionService _positionService;


    }
}
