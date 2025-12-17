using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_WORKITEM")]
    public sealed class _IO_WORKITEM : DynamicStructure
    {
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public IntPtr Routine { get; }
        public IntPtr IoObject { get; }
        public IntPtr Context { get; }
        public IntPtr WorkOnBehalfThread { get; }
        public uint Type { get; }
        public _GUID ActivityId { get; }

        public _IO_WORKITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_WORKITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_WORKITEM.WorkItem),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_WORKITEM.Routine),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IO_WORKITEM.IoObject),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IO_WORKITEM.Context),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IO_WORKITEM.WorkOnBehalfThread),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IO_WORKITEM.Type),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IO_WORKITEM.ActivityId),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_IO_WORKITEM>((mem, ptr) => new _IO_WORKITEM(mem, ptr), offsets);
        }
    }
}