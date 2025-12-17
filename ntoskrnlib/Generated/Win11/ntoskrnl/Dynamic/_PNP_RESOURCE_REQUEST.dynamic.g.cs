using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_RESOURCE_REQUEST")]
    public sealed class _PNP_RESOURCE_REQUEST : DynamicStructure
    {
        public IntPtr PhysicalDevice { get; }
        public uint Flags { get; }
        public uint AllocationType { get; }
        public uint Priority { get; }
        public uint Position { get; }
        public IntPtr ResourceRequirements { get; }
        public IntPtr ReqList { get; }
        public IntPtr ResourceAssignment { get; }
        public IntPtr TranslatedResourceAssignment { get; }
        public int Status { get; }

        public _PNP_RESOURCE_REQUEST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_RESOURCE_REQUEST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_RESOURCE_REQUEST.PhysicalDevice),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.AllocationType),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.Priority),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.Position),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.ResourceRequirements),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.ReqList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.ResourceAssignment),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.TranslatedResourceAssignment),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PNP_RESOURCE_REQUEST.Status),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_PNP_RESOURCE_REQUEST>((mem, ptr) => new _PNP_RESOURCE_REQUEST(mem, ptr), offsets);
        }
    }
}