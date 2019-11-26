using System;

namespace CSharpSevenFeatures.OldFeatures
{
    public class ValueReferenceType
    {
        #region Value Type

        //Value type: bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort
        //a data type is a value type if it holds a data value within its own memory space. It means variable of these data types directly contains their values. 
        //For example, consider integer variables "int i=100;"
        //the system stores 100 in the memory space allocated for the variable 'x'. 100 is stored at some hypothetical location in the memory (0x2342432) for x.

        //Null
        // A value type variable cannot be null becuase it holds a value not a memory address. However, value type variable must be assigned some value before use. 
        //The complier will geven an error if you try to use a local value type variable without assiging a value to it. 
        public void ChangeValue(int j)
        {
            j = 200;

            Console.WriteLine(j);
        }

        public void Initiate()
        {
            int x = 100;

            Console.WriteLine(x);

            ChangeValue(x);

            Console.WriteLine(x);

            var student = new Student { Name = "mateus" };

            Console.WriteLine(student.Name);

            ChangeReferenceType(student);

            Console.WriteLine(student.Name);


        }
        //output
        //100
        //200
        //100
        //When you pass a value type variable from one method to another method, tye system creates a separate copy of a variable in another method,
        //so that if value got changed in the one  method won't affect on the variable in another method.

        #endregion

        #region Reference types

        //Reference type: string, all arrays, even if their elements are value types, class, delegates. 
        //Unlike value types, a reference typs doesn't store its value directly. Instead, it stores the address where the value is being stored. 
        //In other words, a reference types contains a pointer to another memory location that holds the data.

        private string x = "Hello"; //  0x60320 [0x8000](Reference type variable contains address where the value is stored)  -->   0x8000[Hello](Actual value)
                                    // The system selects a random location in memory 0x60320 for the variable x. The value of a variable x is 0x8000 which is the memory address of the actual data value.
                                    // Thus, reference type stores the address of the location where the actual value is stored instead of value itself. 

        //When you passa a reference type variable from one method to another, it doesn't create a new copy;
        //instead, it passes the address of the variable. If we now change the value of the variable in a method, 
        //it will also be reflected in the calling method.

        public void ChangeReferenceType(Student student)
        {
            student.Name = "lucas";
        }
        //output
        //mateus
        //lucas

        //Null
        // References types have null value by default, when they are not initialized. for example, a string variable (or any other variable  of reference type datdatype)
        //without a value assigned to it. in this case, it has a null value, meaning it doesnt point to any other memory location, because it has no value yet. 


        #endregion

        #region Remember
        /*
         * Value types stores the value in its memory space, whereas reference type stores the address of the value where it is stored.
         * Primitive data types and struct are of the 'Value' type. Class objects, string, array, delegates are reference types.
         * Value type passes byval by default. Reference type passes byref by default.
         * Value type and reference types sotred in stack and heap in the memory depends on the scope of the variable. 
         */
        #endregion
    }

    public class Student
    {
        public string Name { get; set; }
    }
}
