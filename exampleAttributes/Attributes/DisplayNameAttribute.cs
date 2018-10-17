using System; // system es el framework

namespace ExampleAttributes.Attributes
{

    public class DisplayNameAttribute : Attribute // se implementa la herencia ya que es una interfaz
    {
        public readonly string DisplayName;

        public DisplayNameAttribute(string displayName) // CONSTRUCTOR: no tiene valor de retorno, es el primer metodo que se ejecuta, tiene el mismo nombre que la clase
        {
            DisplayName = displayName;
        }
    }
}
