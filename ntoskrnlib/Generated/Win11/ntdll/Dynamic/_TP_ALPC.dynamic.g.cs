using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_ALPC")]
    public sealed class _TP_ALPC : DynamicStructure
    {
        public _TP_DIRECT Direct { get; }
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember { get; }
        public IntPtr AlpcPort { get; }
        public int DeferredSendCount { get; }
        public int LastConcurrencyCount { get; }
        public uint Flags { get; }
        public uint ExTypeCallback { get; }
        public uint CompletionListRegistered { get; }
        public uint Reserved { get; }

        public _TP_ALPC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_ALPC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_ALPC.Direct),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_ALPC.CleanupGroupMember),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_TP_ALPC.AlpcPort),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_TP_ALPC.DeferredSendCount),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_TP_ALPC.LastConcurrencyCount),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_TP_ALPC.Flags),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_TP_ALPC.ExTypeCallback),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_TP_ALPC.CompletionListRegistered),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_TP_ALPC.Reserved),
                    new ulong[]
                    {
                        288UL
                    }
                }
            };
            Register<_TP_ALPC>((mem, ptr) => new _TP_ALPC(mem, ptr), offsets);
        }
    }
}