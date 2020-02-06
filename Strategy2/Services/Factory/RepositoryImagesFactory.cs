using Strategy2.Services.Factory.Interfaces;
using Strategy2.Services.Interfaces;

namespace Strategy2.Services.Factory
{
    public class RepositoryImagesFactory : IRepositoryImagesFactory
    {
        public IRepositoryImages GetStrategy(int iTypeExtension)
        {
            IRepositoryImages repositoryImages = null;
            switch (iTypeExtension)
            {
                case 1:
                    repositoryImages = new JPEGStrategy();
                    break;
                case 2:
                    repositoryImages = new PNGStrategy();
                    break;
                case 3:
                    repositoryImages = new BMPStrategy();
                    break;
                default:
                    break;
            }
            return repositoryImages;
        }
    }
}
