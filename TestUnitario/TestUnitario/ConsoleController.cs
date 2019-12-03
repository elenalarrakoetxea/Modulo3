using System;
using System.Collections.Generic;
using System.Text;

namespace TestUnitario
{
    public class ConsoleController
    {
        public string Salute() => SaluteTo("mundo");
        //{
        //    return "Hola mundo";
        //}
        public string SaluteTo(string name)
        {
            if (name is null)
            {
                throw new NullReferenceException("Nombre NULO!!");
            }
            if (string.IsNullOrEmpty(name))
            {
                return "Dime quien eres";
            }
            return $"Hola {name}";
        }
    }
}
