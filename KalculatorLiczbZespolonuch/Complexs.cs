using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Runtime.CompilerServices;

namespace KalculatorLiczbZespolonuch
{
    internal class Complexs
    {
        double[] indeksery = new double[2];
        public double this[char x]
        {
            get
            {
                if (x == 'r')
                {
                    return indeksery[0];
                }
                if (x == 'i')
                {
                    return indeksery[1];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if(x == 'r')
                {
                    indeksery[0] = value;
                    return;
                }
                if(x == 'i')
                {
                    indeksery[1] = value;
                    return;
                }
            }
        }

        public static Complexs operator +(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result['r'] = a['r'] + b['r'];
            result['i'] = a['i'] + b['i'];
            return result;
        }

        public static Complexs operator -(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result['r'] = a['r'] - b['r'];
            result['i'] = a['i'] - b['i'];
            return result;
        }

        public static Complexs operator *(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result['r'] = a['r'] * b['r'] - a['i'] * b['i'];
            result['i'] = a['r'] * b['i'] + b['r'] * a['i'];
            return result;
        }

        public static Complexs operator /(Complexs a, Complexs b)
        {
            Complexs result = new Complexs();
            result['r'] = (a['r'] * b['r'] + a['i'] * b['i']) / (b['r'] * b['r'] + b['i'] * b['i']);
            result['i'] = (b['r'] * a['i'] - a['r'] * b['i']) / (b['r'] * b['r'] + b['i'] * b['i']);
            return result;
        }

        public static bool operator >(Complexs a, Complexs b) => (a['r'] > b['r'] && a['i'] > b['i']);
        public static bool operator <(Complexs a, Complexs b) => (a['r'] < b['r'] && a['i'] < b['i']);
        public static bool operator ==(Complexs a, Complexs b) => (a['r'] == b['r'] && a['i'] == b['i']);
        public static bool operator !=(Complexs a, Complexs b) => (a['r'] != b['r'] || a['i'] != b['i']);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Complexs z = (Complexs)obj;
            return this['r'] == z['r'] && this['i'] == z['i'];
        }
        public override int GetHashCode()
        {
            return (this['r'].GetHashCode() + this['i'].GetHashCode()) / 2;
        }

        public static string Indouble(Complexs a, Complexs b)
        {
            Complex complex1 = new Complex(a['r'], a['i']);
            Complex complex2 = new Complex(b['r'], b['i']);
            double real1 = complex1.Real;
            double real2 = complex2.Real;
            double img1 = complex1.Imaginary;
            double img2 = complex2.Imaginary;
            double res1,res2;
            res1 = real1 + img1;          
            res2 = real2 + img2;         
            return $"Z1 = {res1}; Z2 = {res2}";
        }

        public static string FromDouble(Complexs a, Complexs b)
        {
            string result1,result2;
             if (a['i'] >= 0)
            {
                result1 = $"Z1 = {a['r']}+{a['i']}i; ";
            }
            else
            {
                result1 = $"Z1 = {a['r']}{a['i']}i; ";
            }
            if (b['i'] >= 0)
            {
                result2 = $"Z2 = {b['r']}+{b['i']}i";
            }
            else
            {
                result2 = $"Z2 = {b['r']}{b['i']}i";
            }

            return result1 + result2;
                      
        }

    }
}

