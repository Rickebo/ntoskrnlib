using ntoskrnlib.Structure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ntoskrnlib.Structure
{
    public class DynamicArray : DynamicStructure
    {
        private Type _lastType;
        private int _lastTypeSize;

        public DynamicArray(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {

        }

        [RegisterMethod]
        public static void Register() => DynamicStructure.Register((mem, ptr) => new DynamicArray(mem, ptr));   

        public T Get<T>(int index) where T : struct
        {
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
