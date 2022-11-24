using System;

namespace Arajadranq1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data type                                Data Name          Value


            byte byteType = 255;                  // byte	8-bit unsigned integer	0 to 255
            Console.WriteLine(byteType);

            sbyte sbyteType = -128;
            Console.WriteLine(sbyteType);        //8-bit  signed integer	  -128 to 127


            short shortType = 32222;             //short	16-bit signed integer	-32,768 to 32,767
            Console.WriteLine(shortType);


            ushort ushortType = 65535;           //ushort	16-bit unsigned integer	0 to 65,535
            Console.WriteLine(ushortType);

            int intType = 2147483647;            //int	32-bit signed integer	-2,147,483,648 to 2,147,483,647
            Console.WriteLine(intType);


            uint uintType = 4294967295;          //uint	32-bit unsigned integer	0 to 4,294,967,295	u
            Console.WriteLine(uintType);


            long longType = -9223372036854775808;  //long	64-bit signed integer	-9,223,372,036,854,775,808  to 9,223,372,036,854,775,807 l          
            Console.WriteLine(longType);

            ulong ulongType = 18446744073709551615;   //ulong	64-bit unsigned integer	0 to 18,446,744,073,709,551,615	ul
            Console.WriteLine(ulongType);

            float floatType = 3.40282338f;         //float	32-bit Single-precision floating point type	-3.402823e38 to 3.402823e38	f
            Console.WriteLine(floatType);

            double doubleType = -3.44556856586655; //double	64-bit double-precision floating point type	-1.79769313486232e308 to 1.79769313486232e308	d
            Console.WriteLine(doubleType); ;

            decimal decimalType = 89.000009m; //decimal	128-bit decimal type for financial and monetary calculations	(+ or -)1.0 x 10e-28             to
            Console.WriteLine(decimalType);



            char charType = 'm';             //char	16-bit single Unicode character	Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)
            char charTyp = 'b';
            Console.WriteLine(charType + charTyp);

        }
    }
}