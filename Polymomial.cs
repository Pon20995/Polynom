using System;
using System.Text;

namespace Task_4._5
{
    internal class Polynomial
    {
        public int[] Degrees { get; private set; }

        public Polynomial(int[] degrees)
        {
            Degrees = degrees;
        }

        public static Polynomial operator +(Polynomial polynomial1, Polynomial polynomial2)
        {
            int[] coef1 = polynomial1.Degrees;
            int[] coef2 = polynomial2.Degrees;
            int maxSize = Math.Max(coef1.Length, coef2.Length);
            int minSize = Math.Min(coef1.Length, coef2.Length);

           int[] resultCoef = new int[maxSize] ;

            for (int i = 0; i < minSize; i++)
            {
                resultCoef[i] = coef1[i] + coef2[i];
            }

            int[] biggestArray = coef1.Length > coef2.Length ? coef1 : coef2;

            for (int i = minSize; i < maxSize; i++)
            {
                resultCoef[i] = biggestArray[i];
            }

            var result =new Polynomial(resultCoef);

            return result;

        }
        public static Polynomial operator -(Polynomial polynomial1, Polynomial polynomial2)
        {
            int[] coef1 = polynomial1.Degrees;
            int[] coef2 = polynomial2.Degrees;
            int maxSize = Math.Max(coef1.Length, coef2.Length);
            int minSize = Math.Min(coef1.Length, coef2.Length);

            int[] resultCoef = new int[maxSize];

            for (int i = 0; i < minSize; i++)
            {
                resultCoef[i] = coef1[i] - coef2[i];
            }

            int[] biggestArray = coef1.Length > coef2.Length ? coef1 : coef2;

            for (int i = minSize; i < maxSize; i++)
            {
                resultCoef[i] = biggestArray[i];
            }

            var result = new Polynomial(resultCoef);

            return result;

        }

        public static Polynomial operator *(Polynomial polynomial1, Polynomial polynomial2)
        {
            int[] coef1 = polynomial1.Degrees;
            int[] coef2 = polynomial2.Degrees;
            int maxSize = Math.Max(coef1.Length, coef2.Length);
            int minSize = Math.Min(coef1.Length, coef2.Length);

            int[] resultCoef = new int[maxSize];

            for (int i = 0; i < minSize; i++)
            {
                resultCoef[i] = coef1[i] * coef2[i];
            }
            var result = new Polynomial(resultCoef);

            return result;

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            int coef0 = Degrees[0];

            if (coef0 != 0)
            {
                sb.Append(coef0);
            }

            for (int degreeIndex = 1; degreeIndex < Degrees.Length; degreeIndex++)
            {
                int coef = Degrees[degreeIndex];
                if (coef != 0)
                {
                     if (coef != 0)
                {
                    if (coef > 0)
                    {
                        sb.Append("+");
                    }
                    sb.Append(coef);
           
                    if (degreeIndex != 1)
                    {
                        sb.Append("×^");
                        sb.Append(degreeIndex);
                    }
                    else
                    {
                        sb.Append("×");
                    }
                }
            }
          
            return sb.ToString();
        }

    }
}

