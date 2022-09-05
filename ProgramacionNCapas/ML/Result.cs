using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result
    {
        public bool Correct { get; set; } //Validar
        public string ErrorMessage { get; set; } //excepciones
        public object Object { get; set; } //guardar informacion de 1
        public List<object> Objects { get; set; } //guardar informacion de varios
        public Exception Ex { get; set; } //excepciones
    }
}
