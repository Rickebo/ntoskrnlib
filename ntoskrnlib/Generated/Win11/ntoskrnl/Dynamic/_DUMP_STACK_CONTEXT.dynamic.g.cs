using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DUMP_STACK_CONTEXT")]
    public sealed class _DUMP_STACK_CONTEXT : DynamicStructure
    {
        public _DUMP_INITIALIZATION_CONTEXT Init { get; }
        public _LARGE_INTEGER PartitionOffset { get; }
        public IntPtr DumpPointers { get; }
        public IntPtr StorageInfo { get; }
        public byte UseStorageInfo { get; }
        public uint PointersLength { get; }
        public IntPtr ModulePrefix { get; }
        public _LIST_ENTRY DriverList { get; }
        public _STRING InitMsg { get; }
        public _STRING ProgMsg { get; }
        public _STRING DoneMsg { get; }
        public IntPtr FileObject { get; }
        public uint UsageType { get; }

        public _DUMP_STACK_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DUMP_STACK_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DUMP_STACK_CONTEXT.Init),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.PartitionOffset),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.DumpPointers),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.StorageInfo),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.UseStorageInfo),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.PointersLength),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.ModulePrefix),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.DriverList),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.InitMsg),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.ProgMsg),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.DoneMsg),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.FileObject),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_DUMP_STACK_CONTEXT.UsageType),
                    new ulong[]
                    {
                        368UL
                    }
                }
            };
            Register<_DUMP_STACK_CONTEXT>((mem, ptr) => new _DUMP_STACK_CONTEXT(mem, ptr), offsets);
        }
    }
}