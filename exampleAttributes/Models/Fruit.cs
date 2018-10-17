using ExampleAttributes.Attributes;

namespace ExampleAttributes.Enums
{
    public enum Fruit // enum: para cosas que no tienen tipo, enumera cosas
    {
        [DisplayNameAttribute("Limon")] // llama a displayname para que puedan aparecer los nombres en program
        Lemon,

        [DisplayNameAttribute("Sandia")]
        Watermelon,

        [DisplayNameAttribute("Orange")]
        Orange,

        [DisplayNameAttribute("Pomelo")]
        BloodOrange,

        [DisplayNameAttribute("Kiwi")]
        Kiwi,

        [DisplayNameAttribute("Banana")]
        Banana
    }
}
