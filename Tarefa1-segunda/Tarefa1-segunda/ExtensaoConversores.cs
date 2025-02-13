using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa1_segunda
{
    public class ExtensaoConversores
    {
        public int ConverterStringInt(string numeroString)
        {
            if (int.TryParse(numeroString, out int numeroInt))
            {
                return numeroInt;
            }
            else
            {
                return 0;
            }
        }

        public double ConverterStringDouble(string numeroString) 
        {
            if(double.TryParse(numeroString, out double numeroDouble))
            {
                return numeroDouble;
            }
            else
            {
                return 0;
            }
        }

        public float ConverterStringFloat(string numeroString)
        {
            if (float.TryParse(numeroString, out float numeroFloat))
            {
                return numeroFloat;
            }
            else
            {
                return 0;
            }
        }

        public decimal ConverterStringDecimal(string numeroString)
        {
            if (decimal.TryParse(numeroString, out decimal numeroDecimal))
            {
                return numeroDecimal;
            }
            else
            {
                return 0;
            }
        }
    }
}
