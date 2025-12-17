using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MACHINE_FRAME")]
    public sealed class _MACHINE_FRAME : DynamicStructure
    {
        public ulong Rip { get; }
        public ushort SegCs { get; }
        public ushort[] Fill1 { get; }
        public uint EFlags { get; }
        public uint Fill2 { get; }
        public ulong Rsp { get; }
        public ushort SegSs { get; }
        public ushort[] Fill3 { get; }

        public _MACHINE_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MACHINE_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MACHINE_FRAME.Rip),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MACHINE_FRAME.SegCs),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MACHINE_FRAME.Fill1),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_MACHINE_FRAME.EFlags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MACHINE_FRAME.Fill2),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MACHINE_FRAME.Rsp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MACHINE_FRAME.SegSs),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MACHINE_FRAME.Fill3),
                    new ulong[]
                    {
                        34UL
                    }
                }
            };
            Register<_MACHINE_FRAME>((mem, ptr) => new _MACHINE_FRAME(mem, ptr), offsets);
        }
    }
}