using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT_LIST_ENTRY")]
    public sealed class _DEVICE_OBJECT_LIST_ENTRY : DynamicStructure
    {
        public IntPtr DeviceObject { get; }
        public uint RelationLevel { get; }
        public uint Ordinal { get; }
        public uint Flags { get; }

        public _DEVICE_OBJECT_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_OBJECT_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_OBJECT_LIST_ENTRY.DeviceObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_LIST_ENTRY.RelationLevel),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_LIST_ENTRY.Ordinal),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_LIST_ENTRY.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DEVICE_OBJECT_LIST_ENTRY>((mem, ptr) => new _DEVICE_OBJECT_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}