using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

namespace KalculatorLiczbZespolonuch
{
    internal class Complexs
    {
        public double xR, xI;

        public Complexs Sum(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = a.xR + b.xR;
            result.xI = a.xI + b.xI;
            return result;
        }

        public Complexs Minus(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = a.xR - b.xR;
            result.xI = a.xI - b.xI;
            return result;
        }

        public Complexs Multipl(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = a.xR * b.xR - a.xI * b.xI;
            result.xI = a.xR * b.xI + b.xR * a.xI;
            return result;
        }

        public Complexs Divine(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = (a.xR * b.xR + a.xI * b.xI) / (b.xR * b.xR + b.xI * b.xI);
            result.xI = (b.xR * a.xI - a.xR * b.xI) / (b.xR * b.xR + b.xI * b.xI);
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
        
            Complexs z =(Complexs)obj;
            return xR==z.xR && xI==z.xI;
        }
        public override int GetHashCode()
        {
            return (xR.GetHashCode() + xI.GetHashCode()) / 2;
        }
        public void InDouble()
        {
            
        }
        
        public void OnDouble()
        {

        }
    }
}

