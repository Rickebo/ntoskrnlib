using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KDESCRIPTOR")]
    public sealed class _KDESCRIPTOR : DynamicStructure
    {
        public ushort[] Pad { get; }
        public ushort Limit { get; }
        public IntPtr Base { get; }

        public _KDESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KDESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KDESCRIPTOR.Pad),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KDESCRIPTOR.Limit),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_KDESCRIPTOR.Base),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KDESCRIPTOR>((mem, ptr) => new _KDESCRIPTOR(mem, ptr), offsets);
        }
    }
}