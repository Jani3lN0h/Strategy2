using Strategy2.Services.Interfaces;

namespace Strategy2.Services.Factory.Interfaces
{
    public interface IRepositoryImagesFactory
    {
        IRepositoryImages GetStrategy(int iTypeExtension);
    }
}
