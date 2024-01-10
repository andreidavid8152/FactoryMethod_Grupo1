namespace FactoryMethod_Grupo1.FactoryMethod
{
    public class SillaFactory : MuebleFactory
    {
        public override IMueble GetMueble(string material, string color)
        {
            return new Silla(material, color);
        }
    }
}
