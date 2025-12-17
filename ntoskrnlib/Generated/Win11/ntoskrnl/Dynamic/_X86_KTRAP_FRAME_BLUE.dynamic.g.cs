using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_X86_KTRAP_FRAME_BLUE")]
    public sealed class _X86_KTRAP_FRAME_BLUE : DynamicStructure
    {
        public uint DbgEbp { get; }
        public uint DbgEip { get; }
        public uint DbgArgMark { get; }
        public ushort TempSegCs { get; }
        public byte Logging { get; }
        public byte FrameType { get; }
        public uint TempEsp { get; }
        public uint Dr0 { get; }
        public uint Dr1 { get; }
        public uint Dr2 { get; }
        public uint Dr3 { get; }
        public uint Dr6 { get; }
        public uint Dr7 { get; }
        public uint SegGs { get; }
        public uint SegEs { get; }
        public uint SegDs { get; }
        public uint Edx { get; }
        public uint Ecx { get; }
        public uint Eax { get; }
        public byte PreviousPreviousMode { get; }
        public byte EntropyQueueDpc { get; }
        public byte[] Reserved { get; }
        public uint MxCsr { get; }
        public uint ExceptionList { get; }
        public uint SegFs { get; }
        public uint Edi { get; }
        public uint Esi { get; }
        public uint Ebx { get; }
        public uint Ebp { get; }
        public uint ErrCode { get; }
        public uint Eip { get; }
        public uint SegCs { get; }
        public uint EFlags { get; }
        public uint HardwareEsp { get; }
        public uint HardwareSegSs { get; }
        public uint V86Es { get; }
        public uint V86Ds { get; }
        public uint V86Fs { get; }
        public uint V86Gs { get; }

        public _X86_KTRAP_FRAME_BLUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _X86_KTRAP_FRAME_BLUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.DbgEbp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.DbgEip),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.DbgArgMark),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.TempSegCs),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Logging),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.FrameType),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.TempEsp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Dr0),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Dr1),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Dr2),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Dr3),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Dr6),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Dr7),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.SegGs),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.SegEs),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.SegDs),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Edx),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Ecx),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Eax),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.PreviousPreviousMode),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.EntropyQueueDpc),
                    new ulong[]
                    {
                        69UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Reserved),
                    new ulong[]
                    {
                        70UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.MxCsr),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.ExceptionList),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.SegFs),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Edi),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Esi),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Ebx),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Ebp),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.ErrCode),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.Eip),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.SegCs),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.EFlags),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.HardwareEsp),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.HardwareSegSs),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.V86Es),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.V86Ds),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.V86Fs),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME_BLUE.V86Gs),
                    new ulong[]
                    {
                        136UL
                    }
                }
            };
            Register<_X86_KTRAP_FRAME_BLUE>((mem, ptr) => new _X86_KTRAP_FRAME_BLUE(mem, ptr), offsets);
        }
    }
}