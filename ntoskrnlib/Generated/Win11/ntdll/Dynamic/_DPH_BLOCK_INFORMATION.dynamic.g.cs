using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DPH_BLOCK_INFORMATION")]
    public sealed class _DPH_BLOCK_INFORMATION : DynamicStructure
    {
        public uint StartStamp { get; }
        public IntPtr Heap { get; }
        public ulong RequestedSize { get; }
        public ulong ActualSize { get; }
        public _LIST_ENTRY FreeQueue { get; }
        public _SLIST_ENTRY FreePushList { get; }
        public ushort TraceIndex { get; }
        public IntPtr StackTrace { get; }
        public uint Padding { get; }
        public uint EndStamp { get; }

        public _DPH_BLOCK_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DPH_BLOCK_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DPH_BLOCK_INFORMATION.StartStamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.Heap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.RequestedSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.ActualSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.FreeQueue),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.FreePushList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.TraceIndex),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.StackTrace),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.Padding),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DPH_BLOCK_INFORMATION.EndStamp),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_DPH_BLOCK_INFORMATION>((mem, ptr) => new _DPH_BLOCK_INFORMATION(mem, ptr), offsets);
        }
    }
}