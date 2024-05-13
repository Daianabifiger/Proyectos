namespace App1Interfaces
{
    public class ImplementarJugador
    {
        public static void Main(string[] args)
        {
            Messi messi = new Messi(90, 92, 95, 90, 90, 95);
            Ronaldo ronaldo = new Ronaldo(89, 92, 90, 95, 90, 89);

            messi.correr();
            messi.regatear();

            ronaldo.defender();
            ronaldo.correr();
        }
    }

}