using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KDPC")]
    public sealed class _KDPC : DynamicStructure
    {
        public uint TargetInfoAsUlong { get; }
        public byte Type { get; }
        public byte Importance { get; }
        public ushort Number { get; }
        public _SINGLE_LIST_ENTRY DpcListEntry { get; }
        public ulong ProcessorHistory { get; }
        public IntPtr DeferredRoutine { get; }
        public IntPtr DeferredContext { get; }
        public IntPtr SystemArgument1 { get; }
        public IntPtr SystemArgument2 { get; }
        public IntPtr DpcData { get; }

        public _KDPC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KDPC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KDPC.TargetInfoAsUlong),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KDPC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KDPC.Importance),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KDPC.Number),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KDPC.DpcListEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KDPC.ProcessorHistory),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KDPC.DeferredRoutine),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KDPC.DeferredContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KDPC.SystemArgument1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KDPC.SystemArgument2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KDPC.DpcData),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_KDPC>((mem, ptr) => new _KDPC(mem, ptr), offsets);
        }
    }
}