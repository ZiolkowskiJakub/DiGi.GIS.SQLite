using DiGi.Core.Interfaces;

namespace DiGi.GIS.SQLite
{
    /// <summary>
    /// Provides query-related utility methods for GIS SQLite operations, including the generation of unique references for serializable objects.
    /// </summary>
    public static class Query
    {
        /// <summary>
        /// Generates a unique string reference for the specified <see cref="ISerializableObject"/>. 
        /// If the object implements <see cref="IUniqueObject"/>, its own reference is used; otherwise, a hash code of its JSON representation is returned.
        /// </summary>
        /// <param name="serializableObject">The serializable object for which to generate a unique reference.</param>
        /// <returns>A unique string reference identifying the object, or <c>null</c> if the provided <paramref name="serializableObject"/> is null.</returns>
        public static string Reference(this ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            if (serializableObject is IUniqueObject)
            {
                return ((IUniqueObject)serializableObject).Reference();
            }

            return Core.Convert.ToSystem_String(serializableObject).GetHashCode().ToString(System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}