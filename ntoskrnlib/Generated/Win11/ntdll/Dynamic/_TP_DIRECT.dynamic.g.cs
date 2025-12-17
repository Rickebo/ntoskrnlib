using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_DIRECT")]
    public sealed class _TP_DIRECT : DynamicStructure
    {
        public _TP_TASK Task { get; }
        public ulong Lock { get; }
        public _LIST_ENTRY IoCompletionInformationList { get; }
        public IntPtr Callback { get; }
        public uint NumaNode { get; }
        public byte IdealProcessor { get; }

        public _TP_DIRECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_DIRECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_DIRECT.Task),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_DIRECT.Lock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TP_DIRECT.IoCompletionInformationList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TP_DIRECT.Callback),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TP_DIRECT.NumaNode),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TP_DIRECT.IdealProcessor),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_TP_DIRECT>((mem, ptr) => new _TP_DIRECT(mem, ptr), offsets);
        }
    }
}