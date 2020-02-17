using ConsoleAppStrategyImages.Interfaces;
using System;

namespace ConsoleAppStrategyImages
{
    public class EstrategiaBmp : IEstrategiaImagen
    {
        private string _fileName;
        public EstrategiaBmp(string fileName)
        {
            _fileName = fileName;
        }
        public void CrearImagen()
        {
            _fileName = string.Format("{0}.bmp", _fileName);
            Console.WriteLine("Se ha guardado la imágen'{0}'.", _fileName);
        }
    }
}
