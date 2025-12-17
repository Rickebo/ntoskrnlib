using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER")]
    public sealed class _OBJECT_HEADER : DynamicStructure
    {
        public long PointerCount { get; }
        public long HandleCount { get; }
        public IntPtr NextToFree { get; }
        public _EX_PUSH_LOCK Lock { get; }
        public byte TypeIndex { get; }
        public byte TraceFlags { get; }
        public byte DbgRefTrace { get; }
        public byte DbgTracePermanent { get; }
        public byte InfoMask { get; }
        public byte Flags { get; }
        public byte NewObject { get; }
        public byte KernelObject { get; }
        public byte KernelOnlyAccess { get; }
        public byte ExclusiveObject { get; }
        public byte PermanentObject { get; }
        public byte DefaultSecurityQuota { get; }
        public byte SingleHandleEntry { get; }
        public byte DeletedInline { get; }
        public uint Reserved { get; }
        public IntPtr ObjectCreateInfo { get; }
        public IntPtr QuotaBlockCharged { get; }
        public IntPtr SecurityDescriptor { get; }
        public _QUAD Body { get; }

        public _OBJECT_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HEADER.PointerCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.HandleCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.NextToFree),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.TypeIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.TraceFlags),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.DbgRefTrace),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.DbgTracePermanent),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.InfoMask),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.Flags),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.NewObject),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.KernelObject),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.KernelOnlyAccess),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.ExclusiveObject),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.PermanentObject),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.DefaultSecurityQuota),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.SingleHandleEntry),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.DeletedInline),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.Reserved),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.ObjectCreateInfo),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.QuotaBlockCharged),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.SecurityDescriptor),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER.Body),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_OBJECT_HEADER>((mem, ptr) => new _OBJECT_HEADER(mem, ptr), offsets);
        }
    }
}