using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPFNENTRY3")]
    public sealed class _MMPFNENTRY3 : DynamicStructure
    {
        public byte Priority { get; }
        public byte OnProtectedStandby { get; }
        public byte InPageError { get; }
        public byte SystemChargedPage { get; }
        public byte RemovalRequested { get; }
        public byte ParityError { get; }

        public _MMPFNENTRY3(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPFNENTRY3()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPFNENTRY3.Priority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY3.OnProtectedStandby),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY3.InPageError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY3.SystemChargedPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY3.RemovalRequested),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNENTRY3.ParityError),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPFNENTRY3>((mem, ptr) => new _MMPFNENTRY3(mem, ptr), offsets);
        }
    }
}