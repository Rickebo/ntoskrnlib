using ntoskrnlib.Structure;

using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Structure
{
    [DynamicStructure("DynamicArray")]
    public class DynamicArray : DynamicStructure
    {
        private Type _lastType;
        private int _lastTypeSize;
        private int _length;

        public DynamicArray(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
            _length = 0;
        }

        public int Length
        {
            get => _length;
            internal set => _length = value;
        }

        [RegisterMethod]
        public static void Register() => DynamicStructure.Register((mem, ptr) => new DynamicArray(mem, ptr));   

        public T Get<T>(int index) where T : struct
        {
            if (_length > 0 && index >= _length)
                throw new IndexOutOfRangeException($"Index {index} is out of range for array of length {_length}");

            if (index < 0)
                throw new IndexOutOfRangeException($"Index {index} cannot be negative");

            var size = typeof(T) == _lastType
                ? _lastTypeSize
                : typeof(T).IsEnum
                    ? Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T)))
                    : Marshal.SizeOf<T>();

            _lastType = typeof(T);
            _lastTypeSize = size;

            return ReadHere<T>((ulong)(index * (long)size));
        }

        public T[] GetRange<T>(int length)
            where T : struct
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException(nameof(length), "Length cannot be negative");

            if (_length > 0 && length > _length)
                throw new ArgumentOutOfRangeException(nameof(length), $"Requested length {length} exceeds array length {_length}");

            var size = typeof(T) == _lastType
                ? _lastTypeSize
                : typeof(T).IsEnum
                    ? Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T)))
                    : Marshal.SizeOf<T>();

            _lastType = typeof(T);
            _lastTypeSize = size;

            var array = new T[length];
            for (var i = 0; i < length; i++)
                array[i] = ReadHere<T>((ulong)(i * size));

            return array;
        }

        public void Set<T>(T value, int index) where T : struct
        {
            if (_length > 0 && index >= _length)
                throw new IndexOutOfRangeException($"Index {index} is out of range for array of length {_length}");

            if (index < 0)
                throw new IndexOutOfRangeException($"Index {index} cannot be negative");

            var size = typeof(T) == _lastType
                ? _lastTypeSize
                : typeof(T).IsEnum
                    ? Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T)))
                    : Marshal.SizeOf<T>();

            _lastType = typeof(T);
            _lastTypeSize = size;

            WriteHere<T>(value, (ulong)(index * size));
        }
    }
}
