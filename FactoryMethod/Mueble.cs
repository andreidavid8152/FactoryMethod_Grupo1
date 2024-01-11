namespace FactoryMethod_Grupo1.FactoryMethod
{
    public abstract class Mueble : IMueble
    {

        public int Id { get; set; } // Un identificador único para el mueble en la base de datos
        public string Material { get; protected set; }
        public string Color { get; protected set; }

        protected Mueble(string material, string color)
        {
            Material = material;
            Color = color;
        }

    }
}
