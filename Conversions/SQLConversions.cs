using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace SqlConversions
{
    public static class SQLConversions
    {
        public static T SqlCastAs<T>(this object Value)
        {
            T response = default(T);
            if (!Convert.IsDBNull(Value))
            {
                response = Conversions.Conversions.CastAs<T>(Value); 
            }

            return response;
        }

        public static T SqlTryCastAs<T>(this object Value, T Default = default(T))
        {
            T response = Default;
            if (!Convert.IsDBNull(Value))
            {
                response = Conversions.Conversions.CastAs<T>(Value);
            }

            return response;
        }
    }
}
