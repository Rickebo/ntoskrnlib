using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_LDW_WORK_CONTEXT")]
    public sealed class _MI_LDW_WORK_CONTEXT : DynamicStructure
    {
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public IntPtr FileObject { get; }
        public int ErrorStatus { get; }
        public int Active { get; }
        public byte FreeWhenDone { get; }

        public _MI_LDW_WORK_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_LDW_WORK_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_LDW_WORK_CONTEXT.WorkItem),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_LDW_WORK_CONTEXT.FileObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_LDW_WORK_CONTEXT.ErrorStatus),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_LDW_WORK_CONTEXT.Active),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_LDW_WORK_CONTEXT.FreeWhenDone),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_MI_LDW_WORK_CONTEXT>((mem, ptr) => new _MI_LDW_WORK_CONTEXT(mem, ptr), offsets);
        }
    }
}