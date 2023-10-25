using buclesact3.servicios;

namespace buclesact3.controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            peticionInterfaz pi = new peticionImplementacion();
            int numero = pi.peticionDeNumero();
            calculoInterfaz ci = new calculoImplementacion();
            ci.calcular(numero);
        }
    }
}
