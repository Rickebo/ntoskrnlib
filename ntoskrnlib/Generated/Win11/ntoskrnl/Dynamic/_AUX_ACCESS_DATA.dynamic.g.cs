using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AUX_ACCESS_DATA")]
    public sealed class _AUX_ACCESS_DATA : DynamicStructure
    {
        public IntPtr PrivilegesUsed { get; }
        public _GENERIC_MAPPING GenericMapping { get; }
        public uint AccessesToAudit { get; }
        public uint MaximumAuditMask { get; }
        public _GUID TransactionId { get; }
        public IntPtr NewSecurityDescriptor { get; }
        public IntPtr ExistingSecurityDescriptor { get; }
        public IntPtr ParentSecurityDescriptor { get; }
        public IntPtr DeRefSecurityDescriptor { get; }
        public IntPtr SDLock { get; }
        public _ACCESS_REASONS AccessReasons { get; }
        public byte GenerateStagingEvents { get; }

        public _AUX_ACCESS_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AUX_ACCESS_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AUX_ACCESS_DATA.PrivilegesUsed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.GenericMapping),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.AccessesToAudit),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.MaximumAuditMask),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.TransactionId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.NewSecurityDescriptor),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.ExistingSecurityDescriptor),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.ParentSecurityDescriptor),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.DeRefSecurityDescriptor),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.SDLock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.AccessReasons),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_AUX_ACCESS_DATA.GenerateStagingEvents),
                    new ulong[]
                    {
                        216UL
                    }
                }
            };
            Register<_AUX_ACCESS_DATA>((mem, ptr) => new _AUX_ACCESS_DATA(mem, ptr), offsets);
        }
    }
}