﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.DAOService
{
    static class Utilities
    {
        public static void addCritere(IList<string> champsWhere, IList<object> valuesWhere,IList<string> operators,string champWhere,object valueWhere,string ope){
            if (valueWhere == null)
                return;

            if (valueWhere is string && string.IsNullOrEmpty((string)valueWhere))
                return;
            if (valueWhere is DateTime && DateTime.MinValue.Equals((DateTime)valueWhere))
                return;

            champsWhere.Add(champWhere);
            valuesWhere.Add(valueWhere);
            operators.Add(ope);
        }

    }
}
