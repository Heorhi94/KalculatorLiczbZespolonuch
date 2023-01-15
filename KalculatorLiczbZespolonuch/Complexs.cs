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

        public static Complexs operator +(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = a.xR + b.xR;
            result.xI = a.xI + b.xI;
            return result;
        }

        public static Complexs operator -(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = a.xR - b.xR;
            result.xI = a.xI - b.xI;
            return result;
        }

        public static Complexs operator *(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = a.xR * b.xR - a.xI * b.xI;
            result.xI = a.xR * b.xI + b.xR * a.xI;
            return result;
        }

        public static Complexs operator /(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result.xR = (a.xR * b.xR + a.xI * b.xI) / (b.xR * b.xR + b.xI * b.xI);
            result.xI = (b.xR * a.xI - a.xR * b.xI) / (b.xR * b.xR + b.xI * b.xI);
            return result;
        }

        public static bool operator >(Complexs a, Complexs b) => (a.xR > b.xR && a.xI > b.xI);
        public static bool operator <(Complexs a, Complexs b) => (a.xR < b.xR && a.xI < b.xI);
        public static bool operator ==(Complexs a, Complexs b) => (a.xR == b.xR && a.xI == b.xI);
        public static bool operator !=(Complexs a, Complexs b) => (a.xR != b.xR && a.xI != b.xI || a.xR != b.xR && a.xI == b.xI|| a.xR == b.xR && a.xI != b.xI);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Complexs z = (Complexs)obj;
            return xR == z.xR && xI == z.xI;
        }
        public override int GetHashCode()
        {
            return (xR.GetHashCode() + xI.GetHashCode()) / 2;

        }
    }
}

