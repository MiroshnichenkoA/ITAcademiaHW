using System;

namespace HW_02_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //три примера явного преобразования типов

            sbyte example01 = 10;
            short example02 = example01;

            int example03 = 20;
            long example04 = example03;

            ushort example05 = 30;
            ulong example06 = example05;

            // три примера неявного преобразования типов

            long example11 = 10;
            short example12 = (short)example11;

            uint example13 = 20;
            byte example14 = (byte)example13;

            short example15 = 30;
            byte example16 = (byte)example15;

            // пример операции упаковки

            int boxEx01 = 15;
            object boxEx02 = boxEx01;

            // пример операции распаковки

            long unBox01 = (long)(int)boxEx02;
        



        }
    }
}
