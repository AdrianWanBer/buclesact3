namespace buclesact3.servicios
{
    internal class peticionImplementacion : peticionInterfaz
    {
        public int peticionDeNumero()
        {
            int numeroSeleccionado;
            Console.WriteLine("Escribe un numero entero");
            numeroSeleccionado = Convert.ToInt32(Console.ReadLine());
            return numeroSeleccionado;
        }
    }
}
