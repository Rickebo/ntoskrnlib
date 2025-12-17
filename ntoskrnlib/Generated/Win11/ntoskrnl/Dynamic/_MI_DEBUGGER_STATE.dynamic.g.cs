using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DEBUGGER_STATE")]
    public sealed class _MI_DEBUGGER_STATE : DynamicStructure
    {
        public byte TransientWrite { get; }
        public byte[] DebugPtes { get; }
        public uint PoisonedTb { get; }
        public int InDebugger { get; }
        public byte[] Pfns { get; }
        public byte[] PatchBuffer { get; }
        public uint PatchBufferInsertIndex { get; }
        public uint PatchBufferRemoveIndex { get; }
        public byte[] PatchTableSpace { get; }
        public byte[] PatchTable { get; }
        public int PatchTableLock { get; }
        public uint PatchTableFreeEntry { get; }
        public uint PatchTableEntryCount { get; }

        public _MI_DEBUGGER_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DEBUGGER_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DEBUGGER_STATE.TransientWrite),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.DebugPtes),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PoisonedTb),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.InDebugger),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.Pfns),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchBuffer),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchBufferInsertIndex),
                    new ulong[]
                    {
                        6432UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchBufferRemoveIndex),
                    new ulong[]
                    {
                        6436UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchTableSpace),
                    new ulong[]
                    {
                        6440UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchTable),
                    new ulong[]
                    {
                        18728UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchTableLock),
                    new ulong[]
                    {
                        22824UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchTableFreeEntry),
                    new ulong[]
                    {
                        22828UL
                    }
                },
                {
                    nameof(_MI_DEBUGGER_STATE.PatchTableEntryCount),
                    new ulong[]
                    {
                        22832UL
                    }
                }
            };
            Register<_MI_DEBUGGER_STATE>((mem, ptr) => new _MI_DEBUGGER_STATE(mem, ptr), offsets);
        }
    }
}