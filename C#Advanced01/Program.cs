namespace C_Advanced01
{
    internal class Program
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









        }
    }
}
