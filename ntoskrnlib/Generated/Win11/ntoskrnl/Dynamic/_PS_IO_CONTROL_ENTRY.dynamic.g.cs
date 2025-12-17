using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_IO_CONTROL_ENTRY")]
    public sealed class _PS_IO_CONTROL_ENTRY : DynamicStructure
    {
        public _RTL_BALANCED_NODE VolumeTreeNode { get; }
        public _LIST_ENTRY FreeListEntry { get; }
        public ulong ReservedForParentValue { get; }
        public ulong VolumeKey { get; }
        public _EX_RUNDOWN_REF Rundown { get; }
        public IntPtr IoControl { get; }
        public IntPtr VolumeIoAttribution { get; }

        public _PS_IO_CONTROL_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_IO_CONTROL_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_IO_CONTROL_ENTRY.VolumeTreeNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_IO_CONTROL_ENTRY.FreeListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_IO_CONTROL_ENTRY.ReservedForParentValue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PS_IO_CONTROL_ENTRY.VolumeKey),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PS_IO_CONTROL_ENTRY.Rundown),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PS_IO_CONTROL_ENTRY.IoControl),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PS_IO_CONTROL_ENTRY.VolumeIoAttribution),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_PS_IO_CONTROL_ENTRY>((mem, ptr) => new _PS_IO_CONTROL_ENTRY(mem, ptr), offsets);
        }
    }
}