namespace FactoryMethod_Grupo1.FactoryMethod
{
    public abstract class MuebleFactory
    {
        public abstract IMueble GetMueble(string material, string color);
    }
}
