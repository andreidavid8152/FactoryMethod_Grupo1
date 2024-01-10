namespace FactoryMethod_Grupo1.FactoryMethod
{
    public class Mesa : IMueble
    {
        public string Material { get; private set; }
        public string Color { get; private set; }

        public Mesa(string material, string color)
        {
            Material = material;
            Color = color;
        }
    }
}
