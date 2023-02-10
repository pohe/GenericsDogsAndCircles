using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class BetterObjectComparer<T> where T :IComparable<T>
    {
        public T Largest(T p1, T p2, T p3)
        { 
            if (p1.CompareTo(p2)>0)
            {
                if (p1.CompareTo(p3)>0)
                    return p1;
                else return p3;
            }
            else if (p2.CompareTo(p3)>0) 
                return p2; 
            else return p3; 
        
        }

















        //public T Largest(T p1, T p2, T p3)
        //{
        //    if (p1.CompareTo(p2) < 0)
        //    {
        //        if (p1.CompareTo(p3) <0)
        //            return p1;
        //        else
        //            return p3;
        //    }

        //    return 
        //}
    }
}
