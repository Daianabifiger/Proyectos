using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1Interfaces
{
    internal class Ronaldo: jugador , Ijugador
    {
        public Ronaldo(int velocidad, int tiro, int regate, int defensa, int pase, int fisico) : base (velocidad, tiro, regate, defensa, pase, fisico)
        {

        }

        public void colocarPase()
        {
            throw new NotImplementedException();
        }

        public void correr()
        {
            throw new NotImplementedException();
        }

        public void defender()
        {
            throw new NotImplementedException();
        }

        public void regatear()
        {
            throw new NotImplementedException();
        }

        public void rematar()
        {
            throw new NotImplementedException();
        }

        public void soportarEmbate()
        {
            throw new NotImplementedException();
        }
    }
}
