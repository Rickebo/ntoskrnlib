using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_QUOTA_INFO")]
    public sealed class _OBJECT_HEADER_QUOTA_INFO : DynamicStructure
    {
        public uint PagedPoolCharge { get; }
        public uint NonPagedPoolCharge { get; }
        public uint SecurityDescriptorCharge { get; }
        public uint Reserved1 { get; }
        public IntPtr SecurityDescriptorQuotaBlock { get; }
        public ulong Reserved2 { get; }

        public _OBJECT_HEADER_QUOTA_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HEADER_QUOTA_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HEADER_QUOTA_INFO.PagedPoolCharge),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_QUOTA_INFO.NonPagedPoolCharge),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_QUOTA_INFO.SecurityDescriptorCharge),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_QUOTA_INFO.Reserved1),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_QUOTA_INFO.SecurityDescriptorQuotaBlock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_QUOTA_INFO.Reserved2),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_OBJECT_HEADER_QUOTA_INFO>((mem, ptr) => new _OBJECT_HEADER_QUOTA_INFO(mem, ptr), offsets);
        }
    }
}