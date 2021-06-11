namespace Entendendo_Ref_Out.Models
{
    public class Calculadora
    {
        //Método utiliando ref;
        //A variavel passada como parametro ref, deve ter sido iniciada.
        public static void TriploRef(ref int x)
        {
            x = x * 3;
        }

        //Método utilizando out;
        //Faz o parametro ser uma referencia para a variavel original, mas não exige que a variavel original seja iniciada.
        public static void TriploOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}