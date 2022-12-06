using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemaForms
{
    class Semaforo
    {
        private byte estado;

        public Semaforo()
        {
            estado = 129;
        }

        public void setVerde(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & (int)224);
                this.estado = (byte)((int)this.estado | (int)1);
            }
            else
            {
                this.estado = (byte)((int)this.estado & (int)7);
                this.estado = (byte)((int)this.estado | (int)32);
            }
        }

        public void setAmarelo(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & (int)224);
                this.estado = (byte)((int)this.estado | (int)2);
            }
            else
            {
                this.estado = (byte)((int)this.estado & (int)7);
                this.estado = (byte)((int)this.estado | (int)64);
            }
        }

        public void setVermelho(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & (int)224);
                this.estado = (byte)((int)this.estado | (int)4);
            }
            else
            {
                this.estado = (byte)((int)this.estado & (int)7);
                this.estado = (byte)((int)this.estado | (int)128);
            }
        }

        public byte getEstado()
        {
            return this.estado;
        }

        public int getEstado(int rua)
        {
            // 1. Vd - 2. Am - 3. Vm
            byte aux = 0;

            if (rua == 1)
            {
                aux = (byte)((int)this.estado & (int)7);
                // aux =1,2,4
                return (aux == 4 ? 3 : aux);
            }
            else
            {
                aux = (byte)((int)this.estado & (int)224);
                // aux= 32,64,128
                return (aux == 128 ? 3 : aux == 64 ? 2 : 1);
            }
        }
        public string getEstadoByte()
        {
            string estadobyte
                = (getEstado(2) == 1 ? "001" : getEstado(2) == 2 ? "010" : "100")
                + "XX"
                + (getEstado(1) == 1 ? "001" : getEstado(1) == 2 ? "010" : "100");

            return estadobyte;
        }
    }
}
