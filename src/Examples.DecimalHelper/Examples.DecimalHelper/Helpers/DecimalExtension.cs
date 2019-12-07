using System;

namespace Examples.DecimalHelper.Helpers
{
    public static class DecimalExtension
    {
        /// <summary>
        /// Trunca um número decimal baseado na precisão de casas decimais
        /// </summary>
        /// <param name="precision">O número de casas decimais que o valor será truncado</param>
        public static decimal Truncate(this decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal aux = Math.Truncate(step * value);
            return aux / step;
        }
    }
}
