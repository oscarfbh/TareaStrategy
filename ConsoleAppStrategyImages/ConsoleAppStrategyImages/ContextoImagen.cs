using ConsoleAppStrategyImages.Interfaces;

namespace ConsoleAppStrategyImages
{
    public class ContextoImagen
    {
        private IEstrategiaImagen _estrategiaImagen;

        public void SetEstrategiaImagen(IEstrategiaImagen estrategia)
        {
            _estrategiaImagen = estrategia;
        }

        public void SaveImage()
        {
            _estrategiaImagen.CrearImagen();

        }
    }
}
