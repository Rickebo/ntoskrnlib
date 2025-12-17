using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OB_DUPLICATE_OBJECT_STATE")]
    public sealed class _OB_DUPLICATE_OBJECT_STATE : DynamicStructure
    {
        public IntPtr SourceProcess { get; }
        public IntPtr SourceHandle { get; }
        public IntPtr Object { get; }
        public uint TargetAccess { get; }
        public _HANDLE_TABLE_ENTRY_INFO ObjectInfo { get; }
        public uint HandleAttributes { get; }

        public _OB_DUPLICATE_OBJECT_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OB_DUPLICATE_OBJECT_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OB_DUPLICATE_OBJECT_STATE.SourceProcess),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OB_DUPLICATE_OBJECT_STATE.SourceHandle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OB_DUPLICATE_OBJECT_STATE.Object),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OB_DUPLICATE_OBJECT_STATE.TargetAccess),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OB_DUPLICATE_OBJECT_STATE.ObjectInfo),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_OB_DUPLICATE_OBJECT_STATE.HandleAttributes),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_OB_DUPLICATE_OBJECT_STATE>((mem, ptr) => new _OB_DUPLICATE_OBJECT_STATE(mem, ptr), offsets);
        }
    }
}