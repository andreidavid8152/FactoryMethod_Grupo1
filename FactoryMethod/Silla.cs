namespace FactoryMethod_Grupo1.FactoryMethod
{
    public class Silla : IMueble
    {
        public string Material { get; private set; }
        public string Color { get; private set; }

        public Silla(string material, string color)
        {
            Material = material;
            Color = color;
        }
    }
}
