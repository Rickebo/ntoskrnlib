using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HANDLE_COUNT_ENTRY")]
    public sealed class _OBJECT_HANDLE_COUNT_ENTRY : DynamicStructure
    {
        public IntPtr Process { get; }
        public uint HandleCount { get; }
        public uint LockCount { get; }

        public _OBJECT_HANDLE_COUNT_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HANDLE_COUNT_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HANDLE_COUNT_ENTRY.Process),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HANDLE_COUNT_ENTRY.HandleCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_HANDLE_COUNT_ENTRY.LockCount),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OBJECT_HANDLE_COUNT_ENTRY>((mem, ptr) => new _OBJECT_HANDLE_COUNT_ENTRY(mem, ptr), offsets);
        }
    }
}