using System;

namespace HW_02_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявляю все переменные двумя способами

            sbyte a1 = 1;
            System.SByte a2 = 2;

            short b1 = 3;
            System.Int16 b2 = 4;

            int c1 = 5;
            System.Int32 c2 = 6;

            long d1 = 7;
            System.Int64 d2 = 8;

            byte e1 = 9;
            System.Byte e2 = 10;

            ushort f1 = 11;
            System.UInt16 f2 = 12;

            uint g1 = 13;
            System.UInt32 g2 = 14;

            ulong h1 = 15;
            System.UInt64 h2 = 16;

            char i1 = 'A';
            System.Char i2 = 'B';

            float j1 = 17.1F;
            System.Single j2 = 17.2F;

            double k1 = 17.11;
            System.Double k2 = 17.22;

            bool l1 = false;
            System.Boolean l2 = true;

            decimal m1 = 1.1M;
            System.Decimal m2 = 2.2M;

            object n1 = 18;
            System.Object n2 = 19;

            string o1 = "Hi!";
            System.String o2 = "Bye!";

            //получаю типы этих переменных

            Type nameA1 = a1.GetType();
            Type nameA2 = a2.GetType();

            Type nameB1 = b1.GetType();
            Type nameB2 = b2.GetType();

            Type nameC1 = c1.GetType();
            Type nameC2 = c2.GetType();

            Type nameD1 = d1.GetType();
            Type nameD2 = d2.GetType();

            Type nameE1 = e1.GetType();
            Type nameE2 = e2.GetType();

            Type nameF1 = f1.GetType();
            Type nameF2 = f2.GetType();

            Type nameG1 = g1.GetType();
            Type nameG2 = g2.GetType();

            Type nameH1 = h1.GetType();
            Type nameH2 = h2.GetType();

            Type nameI1 = i1.GetType();
            Type nameI2 = i2.GetType();

            Type nameJ1 = j1.GetType();
            Type nameJ2 = j2.GetType();

            Type nameK1 = k1.GetType();
            Type nameK2 = k2.GetType();

            Type nameL1 = l1.GetType();
            Type nameL2 = l2.GetType();

            Type nameM1 = m1.GetType();
            Type nameM2 = m2.GetType();

            Type nameN1 = n1.GetType();
            Type nameN2 = n2.GetType();

            Type nameO1 = o1.GetType();
            Type nameO2 = o2.GetType();

            //вывожу типы переменных на консоль

            Console.WriteLine(nameA1);
            Console.WriteLine(nameA2);
            Console.WriteLine(nameB1);
            Console.WriteLine(nameB2);
            Console.WriteLine(nameC1);
            Console.WriteLine(nameC2);
            Console.WriteLine(nameD1);
            Console.WriteLine(nameD2);
            Console.WriteLine(nameE1);
            Console.WriteLine(nameE2);
            Console.WriteLine(nameF1);
            Console.WriteLine(nameF2);
            Console.WriteLine(nameG1);
            Console.WriteLine(nameG2);
            Console.WriteLine(nameH1);
            Console.WriteLine(nameH2);
            Console.WriteLine(nameI1);
            Console.WriteLine(nameI2);
            Console.WriteLine(nameJ1);
            Console.WriteLine(nameJ2);
            Console.WriteLine(nameK1);
            Console.WriteLine(nameK2);
            Console.WriteLine(nameL1);
            Console.WriteLine(nameL2);
            Console.WriteLine(nameM1);
            Console.WriteLine(nameM2);
            Console.WriteLine(nameN1);
            Console.WriteLine(nameN2);
            Console.WriteLine(nameO1);
            Console.WriteLine(nameO2);

        }
    }
}
