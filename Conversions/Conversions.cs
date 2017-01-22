using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public static class Conversions
    {
        
        public static T CastAs<T>(this object Value)
        {
            return (T)Convert.ChangeType(Value, Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T));
        }
         
        public static T TryCastAs<T>(this object Value, T Default = default(T))  
        { 
            T response;
              
            try
            {
                response = Value.CastAs<T>();
            }
            catch
            {
                response = Default;
            }
             
            return response; 
        }

        public static bool CanCastAs<T>(this object Value)
        {
            bool response = true;
            try
            {
                Value.CastAs<T>();
            }
            catch
            {
                response = false;
            }

            return response;
        }
    }
}
