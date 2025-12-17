using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_TYPE_INITIALIZER")]
    public sealed class _OBJECT_TYPE_INITIALIZER : DynamicStructure
    {
        public ushort Length { get; }
        public ushort ObjectTypeFlags { get; }
        public byte CaseInsensitive { get; }
        public byte UnnamedObjectsOnly { get; }
        public byte UseDefaultObject { get; }
        public byte SecurityRequired { get; }
        public byte MaintainHandleCount { get; }
        public byte MaintainTypeList { get; }
        public byte SupportsObjectCallbacks { get; }
        public byte CacheAligned { get; }
        public byte UseExtendedParameters { get; }
        public byte SeTrustConstraintMaskPresent { get; }
        public byte Reserved { get; }
        public uint ObjectTypeCode { get; }
        public uint InvalidAttributes { get; }
        public _GENERIC_MAPPING GenericMapping { get; }
        public uint ValidAccessMask { get; }
        public uint RetainAccess { get; }
        public uint PoolType { get; }
        public uint DefaultPagedPoolCharge { get; }
        public uint DefaultNonPagedPoolCharge { get; }
        public IntPtr DumpProcedure { get; }
        public IntPtr OpenProcedure { get; }
        public IntPtr CloseProcedure { get; }
        public IntPtr DeleteProcedure { get; }
        public IntPtr ParseProcedure { get; }
        public IntPtr ParseProcedureEx { get; }
        public IntPtr SecurityProcedure { get; }
        public IntPtr QueryNameProcedure { get; }
        public IntPtr OkayToCloseProcedure { get; }
        public uint WaitObjectFlagMask { get; }
        public ushort WaitObjectFlagOffset { get; }
        public ushort WaitObjectPointerOffset { get; }

        public _OBJECT_TYPE_INITIALIZER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_TYPE_INITIALIZER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.ObjectTypeFlags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.CaseInsensitive),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.UnnamedObjectsOnly),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.UseDefaultObject),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.SecurityRequired),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.MaintainHandleCount),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.MaintainTypeList),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.SupportsObjectCallbacks),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.CacheAligned),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.UseExtendedParameters),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.SeTrustConstraintMaskPresent),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.ObjectTypeCode),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.InvalidAttributes),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.GenericMapping),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.ValidAccessMask),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.RetainAccess),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.PoolType),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.DefaultPagedPoolCharge),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.DefaultNonPagedPoolCharge),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.DumpProcedure),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.OpenProcedure),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.CloseProcedure),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.DeleteProcedure),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.ParseProcedure),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.ParseProcedureEx),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.SecurityProcedure),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.QueryNameProcedure),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.OkayToCloseProcedure),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.WaitObjectFlagMask),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.WaitObjectFlagOffset),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE_INITIALIZER.WaitObjectPointerOffset),
                    new ulong[]
                    {
                        118UL
                    }
                }
            };
            Register<_OBJECT_TYPE_INITIALIZER>((mem, ptr) => new _OBJECT_TYPE_INITIALIZER(mem, ptr), offsets);
        }
    }
}