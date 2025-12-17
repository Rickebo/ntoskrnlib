using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_EXTENDED_ENTRY")]
    public sealed class _HEAP_EXTENDED_ENTRY : DynamicStructure
    {
        public IntPtr Reserved { get; }
        public ushort FunctionIndex { get; }
        public ushort ContextValue { get; }
        public uint InterceptorValue { get; }
        public ushort UnusedBytesLength { get; }
        public byte EntryOffset { get; }
        public byte ExtendedBlockSignature { get; }

        public _HEAP_EXTENDED_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_EXTENDED_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_EXTENDED_ENTRY.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_EXTENDED_ENTRY.FunctionIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_EXTENDED_ENTRY.ContextValue),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_HEAP_EXTENDED_ENTRY.InterceptorValue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_EXTENDED_ENTRY.UnusedBytesLength),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_EXTENDED_ENTRY.EntryOffset),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HEAP_EXTENDED_ENTRY.ExtendedBlockSignature),
                    new ulong[]
                    {
                        15UL
                    }
                }
            };
            Register<_HEAP_EXTENDED_ENTRY>((mem, ptr) => new _HEAP_EXTENDED_ENTRY(mem, ptr), offsets);
        }
    }
}