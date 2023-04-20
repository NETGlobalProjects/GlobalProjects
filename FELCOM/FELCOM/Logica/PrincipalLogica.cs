using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELCOM.Logica
{
    internal class PrincipalLogica
    {
        private static PrincipalLogica _instancia = null;
        public PrincipalLogica()
        {
        }
        public static PrincipalLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PrincipalLogica();
                }
                return _instancia;
            }
        }
        public int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
