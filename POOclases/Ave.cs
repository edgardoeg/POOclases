
namespace POOclases
{
    public class Ave
    {
        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Color { get; set; }
        public double Tamano { get; set; }
        public string? Habitat { get; set; }
        
        public Familia_Ave? Familia { get; set; }


        //constructor
        public Ave()
        {
            Familia = new Familia_Ave();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Ave: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano} cm");
            Console.WriteLine($"Hábitat: {Habitat}");
            Console.WriteLine($"Familia: {Familia.Nombre}");
            Console.WriteLine($"Número de especies: {Familia.numeroEspecie}");
            Console.WriteLine($"Características: {Familia.Caracteristicas}");
            Console.WriteLine("--------------------------------------------------");
        }
}
}
