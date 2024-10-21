using DiGi.Core.Interfaces;

namespace DiGi.GIS.SQLite
{
    public static class Query
    {
        public static string Reference(this ISerializableObject serializableObject)
        {
            if(serializableObject == null)
            {
                return null;
            }

            if(serializableObject is IUniqueObject)
            {
                return ((IUniqueObject)serializableObject).Guid.ToString();
            }

            return Core.Convert.ToString(serializableObject).GetHashCode().ToString();
        }

    }
}
