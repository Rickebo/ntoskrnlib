using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KIST_LINK_FRAME")]
    public sealed class _KIST_LINK_FRAME : DynamicStructure
    {
        public IntPtr IstBaseFrame { get; }
        public uint Signature { get; }
        public uint Reserved0 { get; }
        public ulong[] Reserved { get; }

        public _KIST_LINK_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KIST_LINK_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KIST_LINK_FRAME.IstBaseFrame),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KIST_LINK_FRAME.Signature),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KIST_LINK_FRAME.Reserved0),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KIST_LINK_FRAME.Reserved),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KIST_LINK_FRAME>((mem, ptr) => new _KIST_LINK_FRAME(mem, ptr), offsets);
        }
    }
}