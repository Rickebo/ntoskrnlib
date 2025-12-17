using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_IMAGE_INFO_REF")]
    public sealed class _MI_IMAGE_INFO_REF : DynamicStructure
    {
        public int LongValue { get; }
        public ulong FullValue { get; }
        public IntPtr PointerValue { get; }
        public ulong AllFlags { get; }
        public ulong DebugRecordsPresent { get; }

        public _MI_IMAGE_INFO_REF(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_IMAGE_INFO_REF()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_IMAGE_INFO_REF.LongValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IMAGE_INFO_REF.FullValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IMAGE_INFO_REF.PointerValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IMAGE_INFO_REF.AllFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IMAGE_INFO_REF.DebugRecordsPresent),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_IMAGE_INFO_REF>((mem, ptr) => new _MI_IMAGE_INFO_REF(mem, ptr), offsets);
        }
    }
}