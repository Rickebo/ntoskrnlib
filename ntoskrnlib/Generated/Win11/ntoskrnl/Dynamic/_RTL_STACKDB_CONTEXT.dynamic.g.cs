using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_STACKDB_CONTEXT")]
    public sealed class _RTL_STACKDB_CONTEXT : DynamicStructure
    {
        public _RTL_HASH_TABLE StackSegmentTable { get; }
        public _RTL_HASH_TABLE StackEntryTable { get; }
        public _RTL_SRWLOCK StackEntryTableLock { get; }
        public _RTL_SRWLOCK SegmentTableLock { get; }
        public IntPtr Allocate { get; }
        public IntPtr Free { get; }
        public IntPtr AllocatorContext { get; }

        public _RTL_STACKDB_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_STACKDB_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_STACKDB_CONTEXT.StackSegmentTable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_STACKDB_CONTEXT.StackEntryTable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_STACKDB_CONTEXT.StackEntryTableLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_STACKDB_CONTEXT.SegmentTableLock),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_STACKDB_CONTEXT.Allocate),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_RTL_STACKDB_CONTEXT.Free),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_RTL_STACKDB_CONTEXT.AllocatorContext),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_RTL_STACKDB_CONTEXT>((mem, ptr) => new _RTL_STACKDB_CONTEXT(mem, ptr), offsets);
        }
    }
}