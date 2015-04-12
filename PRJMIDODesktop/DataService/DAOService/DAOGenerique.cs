using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.DAOService
{
    public static class DAOGenerique
    {

        public static bool insert(){
            return true;
        }
        public static bool delete()
        {
            return true;
        }
        public static T find<T>(int id) where T : new()
        {
            return new T();
        }
        public static IEnumerable<T> findAll<T>()
        {
         
            string name = typeof(T).Name;
            return null;
        }
      
    }
}
