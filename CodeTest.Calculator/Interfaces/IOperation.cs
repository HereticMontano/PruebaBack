
namespace CodeTest.Calculator.Interfaces
{
    public interface IOperation
    {
        /* Todas las operaciones van a recivir al menos un parametro obligatorio y podran aceptar 1 o N parametros mas, 
         * la idea es poder dar soporte para operaciones que necesitan dos o mas operadores para llevarse acabo 
         * como operaciones mas simples de un solo operador (logaritmos, tangentes, cotangentes, etc)*/
        int Calculate(int firstValue, params int[] values);
    }
}
