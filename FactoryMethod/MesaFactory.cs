namespace FactoryMethod_Grupo1.FactoryMethod
{
    public class MesaFactory : MuebleFactory
    {
        public override IMueble GetMueble(string material, string color)
        {
            return new Mesa(material, color);
        }
    }
}
