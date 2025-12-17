using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_TYPE")]
    public sealed class _OBJECT_TYPE : DynamicStructure
    {
        public _LIST_ENTRY TypeList { get; }
        public _UNICODE_STRING Name { get; }
        public IntPtr DefaultObject { get; }
        public byte Index { get; }
        public uint TotalNumberOfObjects { get; }
        public uint TotalNumberOfHandles { get; }
        public uint HighWaterNumberOfObjects { get; }
        public uint HighWaterNumberOfHandles { get; }
        public _OBJECT_TYPE_INITIALIZER TypeInfo { get; }
        public _EX_PUSH_LOCK TypeLock { get; }
        public uint Key { get; }
        public _LIST_ENTRY CallbackList { get; }
        public uint SeMandatoryLabelMask { get; }
        public uint SeTrustConstraintMask { get; }

        public _OBJECT_TYPE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_TYPE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_TYPE.TypeList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.Name),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.DefaultObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.Index),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.TotalNumberOfObjects),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.TotalNumberOfHandles),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.HighWaterNumberOfObjects),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.HighWaterNumberOfHandles),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.TypeInfo),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.TypeLock),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.Key),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.CallbackList),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.SeMandatoryLabelMask),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_OBJECT_TYPE.SeTrustConstraintMask),
                    new ulong[]
                    {
                        220UL
                    }
                }
            };
            Register<_OBJECT_TYPE>((mem, ptr) => new _OBJECT_TYPE(mem, ptr), offsets);
        }
    }
}