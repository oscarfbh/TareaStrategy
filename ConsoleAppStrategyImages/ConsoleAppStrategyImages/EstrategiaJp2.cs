using ConsoleAppStrategyImages.Interfaces;
using System;

namespace ConsoleAppStrategyImages
{
    public class EstrategiaJp2 : IEstrategiaImagen
    {
        private string _fileName;
        public EstrategiaJp2(string fileName)
        {
            _fileName = fileName;
        }
        public void CrearImagen()
        {
            _fileName = string.Format("{0}.jp2", _fileName);
            Console.WriteLine("Se ha guardado la imágen'{0}'.", _fileName);
        }
    }
}
