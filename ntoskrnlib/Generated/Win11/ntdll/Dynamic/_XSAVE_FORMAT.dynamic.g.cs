using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_XSAVE_FORMAT")]
    public sealed class _XSAVE_FORMAT : DynamicStructure
    {
        public ushort ControlWord { get; }
        public ushort StatusWord { get; }
        public byte TagWord { get; }
        public byte Reserved1 { get; }
        public ushort ErrorOpcode { get; }
        public uint ErrorOffset { get; }
        public ushort ErrorSelector { get; }
        public ushort Reserved2 { get; }
        public uint DataOffset { get; }
        public ushort DataSelector { get; }
        public ushort Reserved3 { get; }
        public uint MxCsr { get; }
        public uint MxCsr_Mask { get; }
        public byte[] FloatRegisters { get; }
        public byte[] XmmRegisters { get; }
        public byte[] Reserved4 { get; }

        public _XSAVE_FORMAT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSAVE_FORMAT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSAVE_FORMAT.ControlWord),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.StatusWord),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.TagWord),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.Reserved1),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.ErrorOpcode),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.ErrorOffset),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.ErrorSelector),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.Reserved2),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.DataOffset),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.DataSelector),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.Reserved3),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.MxCsr),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.MxCsr_Mask),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.FloatRegisters),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.XmmRegisters),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_XSAVE_FORMAT.Reserved4),
                    new ulong[]
                    {
                        416UL
                    }
                }
            };
            Register<_XSAVE_FORMAT>((mem, ptr) => new _XSAVE_FORMAT(mem, ptr), offsets);
        }
    }
}