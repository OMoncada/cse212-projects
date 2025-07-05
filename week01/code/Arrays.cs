public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Paso 1: Crear un arreglo de tipo double con la longitud solicitada.
        // Paso 2: Recorrer ese arreglo con un bucle for.
        // Paso 3: En cada posición, asignar el múltiplo correspondiente: number * (índice + 1).
        // Paso 4: Retornar el arreglo completo.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Paso 1: Obtener los últimos 'amount' elementos con GetRange.
        // Paso 2: Eliminar esos elementos del final con RemoveRange.
        // Paso 3: Insertarlos al principio de la lista con InsertRange.

        List<int> segment = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, segment);

    }
}
