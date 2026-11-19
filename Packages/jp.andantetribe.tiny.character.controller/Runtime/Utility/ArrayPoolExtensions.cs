using System;
using System.Buffers;

namespace Unity.TinyCharacterController.Utility
{
    internal static class ArrayPoolExtensions
    {
        /// <summary>Rents an array and returns it to the same pool when the handle is disposed.</summary>
        public static Handle<T> Rent<T>(this ArrayPool<T> pool, int minimumLength, out T[] array) =>
            new(pool, array = pool.Rent(minimumLength));

        public readonly struct Handle<T> : IDisposable
        {
            private readonly ArrayPool<T> _pool;
            private readonly T[] _array;

            internal Handle(ArrayPool<T> pool, T[] array)
            {
                _pool = pool;
                _array = array;
            }

            void IDisposable.Dispose() => _pool.Return(_array);
        }
    }
}
