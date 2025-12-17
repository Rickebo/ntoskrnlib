using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_HANDLEREF")]
    public sealed class _NT_IORING_HANDLEREF : DynamicStructure
    {
        public IntPtr Handle { get; }
        public uint HandleIndex { get; }

        public _NT_IORING_HANDLEREF(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_HANDLEREF()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_HANDLEREF.Handle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_HANDLEREF.HandleIndex),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_NT_IORING_HANDLEREF>((mem, ptr) => new _NT_IORING_HANDLEREF(mem, ptr), offsets);
        }
    }
}