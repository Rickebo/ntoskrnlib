using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Tests;

/// <summary>
/// Simple in-memory implementation of IMemorySource for testing purposes.
/// Uses a byte array to simulate memory access.
/// </summary>
internal sealed class TestMemorySource : IMemorySource
{
    private readonly byte[] _memory;

    public TestMemorySource(int size)
    {
        _memory = new byte[size];
    }

    public T Read<T>(MemoryPointer address) where T : struct
    {
        var size = Unsafe.SizeOf<T>();
        var offset = checked((int)address.Value);

        if (offset < 0 || offset + size > _memory.Length)
            throw new ArgumentOutOfRangeException(nameof(address),
                $"Address {address.Value:X} with size {size} is out of bounds (memory size: {_memory.Length})");

        Span<byte> span = _memory.AsSpan(offset, size);
        return MemoryMarshal.Read<T>(span);
    }

    public void Write<T>(MemoryPointer address, T value) where T : struct
    {
        var size = Unsafe.SizeOf<T>();
        var offset = checked((int)address.Value);

        if (offset < 0 || offset + size > _memory.Length)
            throw new ArgumentOutOfRangeException(nameof(address),
                $"Address {address.Value:X} with size {size} is out of bounds (memory size: {_memory.Length})");

        Span<byte> span = _memory.AsSpan(offset, size);
        MemoryMarshal.Write(span, in value);
    }

    /// <summary>
    /// Convenience method to write multiple values at sequential addresses
    /// </summary>
    public void WriteSequential<T>(MemoryPointer startAddress, params T[] values) where T : struct
    {
        var size = Unsafe.SizeOf<T>();
        var current = startAddress;

        foreach (var value in values)
        {
            Write(current, value);
            current += (ulong)size;
        }
    }

    /// <summary>
    /// Fills a region of memory with a specific byte value
    /// </summary>
    public void Fill(MemoryPointer address, int length, byte value)
    {
        var offset = checked((int)address.Value);

        if (offset < 0 || offset + length > _memory.Length)
            throw new ArgumentOutOfRangeException(nameof(address));

        _memory.AsSpan(offset, length).Fill(value);
    }

    /// <summary>
    /// Clears (zeros) a region of memory
    /// </summary>
    public void Clear(MemoryPointer address, int length)
    {
        Fill(address, length, 0);
    }

    /// <summary>
    /// Gets the total memory size
    /// </summary>
    public int Size => _memory.Length;
}
