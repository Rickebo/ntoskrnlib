using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_IMAGE_ADDITIONAL_INFO")]
    public sealed class _MI_IMAGE_ADDITIONAL_INFO : DynamicStructure
    {
        public _MI_PROTOTYPE_PTES_NODE ProtosNode { get; }
        public IntPtr DynamicRelocations { get; }
        public _IMAGE_SECURITY_CONTEXT SecurityContext { get; }
        public IntPtr ImageFileExtents { get; }
        public _unnamed_tag_ u { get; }
        public uint Unused { get; }
        public ulong StrongImageReference { get; }

        public _MI_IMAGE_ADDITIONAL_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_IMAGE_ADDITIONAL_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_IMAGE_ADDITIONAL_INFO.ProtosNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IMAGE_ADDITIONAL_INFO.DynamicRelocations),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_IMAGE_ADDITIONAL_INFO.SecurityContext),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_IMAGE_ADDITIONAL_INFO.ImageFileExtents),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_IMAGE_ADDITIONAL_INFO.u),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_IMAGE_ADDITIONAL_INFO.Unused),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_MI_IMAGE_ADDITIONAL_INFO.StrongImageReference),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MI_IMAGE_ADDITIONAL_INFO>((mem, ptr) => new _MI_IMAGE_ADDITIONAL_INFO(mem, ptr), offsets);
        }
    }
}