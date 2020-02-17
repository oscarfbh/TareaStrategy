using ConsoleAppStrategyImages.Interfaces;
using System;

namespace ConsoleAppStrategyImages
{
    public class EstrategiaJpg : IEstrategiaImagen
    {
        private string _fileName;
        public EstrategiaJpg(string fileName)
        {
            _fileName = fileName;
        }
        public void CrearImagen()
        {
            _fileName = string.Format("{0}.jpg", _fileName);
            Console.WriteLine("Se ha guardado la imágen'{0}'.", _fileName);
        }
    }
}
