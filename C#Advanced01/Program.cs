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























        }
    }
}
