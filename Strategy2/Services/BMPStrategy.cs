using Strategy2.Services.Interfaces;

namespace Strategy2.Services
{
    public class BMPStrategy : IRepositoryImages
    {
        public string SaveImage(string cName, string cTypeExtension)
        {
            return string.Format("Se ha guardado la imagen {0}.{1} Correctamente.", cName, cTypeExtension);
        }
    }
}
