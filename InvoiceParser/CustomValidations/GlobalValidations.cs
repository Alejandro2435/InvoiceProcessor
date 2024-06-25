using System;
using System.Collections.Generic;

namespace InvoiceParser.CustomValidations
{
    public class GlobalValidations<T>
    {
        /// <summary>
        /// <para>Verifica si un atributo es nulo.</para>
        /// <para>Se usa en atributos nativos.</para>
        /// </summary>
        public static readonly Predicate<T> NotNull = attr => attr != null;
        /// <summary>
        /// <para>Verifica si un atributo de tipo String es nulo o está vacío.</para>
        /// <para>Se usa en atributos de tipo String.</para>
        /// </summary>
        public static readonly Predicate<string> NotNullOrEmpty = attr => attr != null && attr != string.Empty;
        /// <summary>
        /// <para>Verifica si una lista de objetos de un tipo especificado tiene al menos un elemento.</para>
        /// </summary>
        public static readonly Predicate<ICollection<T>> HasElements = list => list.Count > 0;
        /// <summary>
        /// <para>Verifica si existe un objeto o lista del tipo especificado.</para>
        /// <para>Se usa en objetos y listas.</para>
        /// </summary>
        public static readonly Predicate<T> Exists = obj => obj != null;
        /// <summary>
        /// <para>Verifica si existe un elemento en una lista del tipo especificado, en una posición especificada.</para>
        /// <para>Se usa en listas.</para>
        /// </summary>

        public static readonly Func<ICollection<T>, int, bool> ExistsInCollection = (collection, position) => position < collection.Count;
    }
}
