using System;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ntoskrnlib.Structure;

namespace StructureDemo;

internal sealed class SimpleMemorySource : IMemorySource
{
    private readonly byte[] _mem;
    public SimpleMemorySource(int size) => _mem = new byte[size];

    public T Read<T>(MemoryPointer address) where T : struct
    {
        var size = Unsafe.SizeOf<T>();
        var offset = checked((int)address.Value);
        Span<byte> span = _mem.AsSpan(offset, size);
        return MemoryMarshal.Read<T>(span);
    }

    public void Write<T>(MemoryPointer address, T value) where T : struct
    {
        var size = Unsafe.SizeOf<T>();
        var offset = checked((int)address.Value);
        Span<byte> span = _mem.AsSpan(offset, size);
        MemoryMarshal.Write(span, ref value);
    }
}

