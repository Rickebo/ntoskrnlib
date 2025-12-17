using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_CREATE_INFORMATION")]
    public sealed class _OBJECT_CREATE_INFORMATION : DynamicStructure
    {
        public uint Attributes { get; }
        public IntPtr RootDirectory { get; }
        public sbyte ProbeMode { get; }
        public uint PagedPoolCharge { get; }
        public uint NonPagedPoolCharge { get; }
        public uint SecurityDescriptorCharge { get; }
        public IntPtr SecurityDescriptor { get; }
        public IntPtr SecurityQos { get; }
        public _SECURITY_QUALITY_OF_SERVICE SecurityQualityOfService { get; }

        public _OBJECT_CREATE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_CREATE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_CREATE_INFORMATION.Attributes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.RootDirectory),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.ProbeMode),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.PagedPoolCharge),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.NonPagedPoolCharge),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.SecurityDescriptorCharge),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.SecurityDescriptor),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.SecurityQos),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_OBJECT_CREATE_INFORMATION.SecurityQualityOfService),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_OBJECT_CREATE_INFORMATION>((mem, ptr) => new _OBJECT_CREATE_INFORMATION(mem, ptr), offsets);
        }
    }
}