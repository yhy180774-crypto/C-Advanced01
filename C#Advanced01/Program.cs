namespace C_Advanced01
{
    internal partial class Program
    {

        static void Main(string[] args)
        {


            #region Question01

            /// Q1: What is a generic class? Why use generics?
            ///
            /// A generic class is a class that works with a type parameter.
            /// The type is specified when creating an object.
            ///
            /// Generics allow us to write reusable and type-safe code.
            /// They also reduce code duplication and avoid unnecessary casting.

            #endregion



            #region Question02

            /// Q2: Write a generic class Container<T> with Add and Get methods.
            ///
            /// public class Container<T>
            /// {
            ///     private T item;
            ///
            ///     public void Add(T value)
            ///     {
            ///         item = value;
            ///     }
            ///
            ///     public T Get()
            ///     {
            ///         return item;
            ///     }
            /// }

            #endregion


            #region Question03

            /// Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            /// 
            /// Multiple type parameters allow a generic class or method
            /// to work with more than one data type.
            ///
            /// public class Pair<TKey, TValue>
            /// {
            ///     public TKey Key { get; set; }
            ///     public TValue Value { get; set; }
            ///
            ///     public Pair(TKey key, TValue value)
            ///     {
            ///         Key = key;
            ///         Value = value;
            ///     }
            /// }

            #endregion


            #region Question04

            /// Q4: What is a generic method? Write Swap<T> method.
            ///
            /// A generic method is a method that uses a type parameter
            /// so it can work with different data types.
            ///
            /// public static void Swap<T>(ref T a, ref T b)
            /// {
            ///     T temp = a;
            ///     a = b;
            ///     b = temp;
            /// }

            #endregion


            #region Question05

            /// Q5: Write a generic method FindMax<T> that finds maximum value.
            ///
            /// public static T FindMax<T>(T a, T b)
            ///     where T : IComparable<T>
            /// {
            ///     if (a.CompareTo(b) > 0)
            ///         return a;
            ///
            ///     return b;
            /// }

            #endregion


            #region Question06

            /// Q6: What is a generic interface? Write IRepository<T>.
            ///
            /// A generic interface is an interface that uses a type parameter.
            ///
            /// public interface IRepository<T>
            /// {
            ///     void Add(T item);
            ///     T Get(int index);
            /// }

            #endregion



            #region Question07

            /// Q7: What is the 'struct' constraint? Write an example.
            ///
            /// The struct constraint means that T must be a value type.
            ///
            /// public class ValueContainer<T>
            ///     where T : struct
            /// {
            ///     public T Value { get; set; }
            /// }

            #endregion



            #region Question08

            /// Q8: What is the 'class' constraint? Write an example.
            ///
            /// The class constraint means that T must be a reference type.
            ///
            /// public class ReferenceContainer<T>
            ///     where T : class
            /// {
            ///     public T Value { get; set; }
            /// }

            #endregion



            #region Question09

            /// Q9: What is the 'new()' constraint? Write an example.
            ///
            /// The new() constraint means that T must have a public parameterless constructor.
            ///
            /// public class Factory<T>
            ///     where T : new()
            /// {
            ///     public T Create()
            ///     {
            ///         return new T();
            ///     }
            /// }

            #endregion



            #region Question10

            /// Q10: What is the interface constraint? Write an example.
            ///
            /// An interface constraint means that T must implement
            /// the specified interface.
            ///
            /// public interface IPrintable
            /// {
            ///     void Print();
            /// }
            ///
            /// public class Printer<T>
            ///     where T : IPrintable
            /// {
            ///     public void PrintItem(T item)
            ///     {
            ///         item.Print();
            ///     }
            /// }

            #endregion


            #region Question11

            /// Q11: What is the base class constraint? Write an example.
            ///
            /// A base class constraint means that T must inherit from
            /// the specified base class.
            ///
            /// public class Animal
            /// {
            ///     public void Eat()
            ///     {
            ///         Console.WriteLine("Eating...");
            ///     }
            /// }
            ///
            /// public class AnimalContainer<T>
            ///     where T : Animal
            /// {
            ///     public void MakeAnimalEat(T animal)
            ///     {
            ///         animal.Eat();
            ///     }
            /// }

            #endregion




            #region Question12

            /// Q12: How do you apply multiple constraints? Write an example.
            ///
            /// Multiple constraints can be applied using multiple where clauses
            /// or by combining constraints in one where clause.
            ///
            /// public class Repository<T>
            ///     where T : class, IPrintable, new()
            /// {
            ///     public T Create()
            ///     {
            ///         return new T();
            ///     }
            /// }

            #endregion



            #region Question13

            /// Q13: What does the 'default' keyword do in generics?
            ///
            /// The default keyword returns the default value of a type.
            ///
            /// For value types such as int, the default value is 0.
            /// For reference types such as string, the default value is null.
            ///
            /// Example:
            ///
            /// int number = default;
            /// string text = default;

            #endregion





        }
    }
}
