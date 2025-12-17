using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_REF_INFO")]
    public sealed class _OBJECT_REF_INFO : DynamicStructure
    {
        public IntPtr ObjectHeader { get; }
        public IntPtr NextRef { get; }
        public byte[] ImageFileName { get; }
        public ushort NextPos { get; }
        public ushort MaxStacks { get; }
        public byte[] StackInfo { get; }

        public _OBJECT_REF_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_REF_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_REF_INFO.ObjectHeader),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_REF_INFO.NextRef),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_REF_INFO.ImageFileName),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_REF_INFO.NextPos),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_REF_INFO.MaxStacks),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_OBJECT_REF_INFO.StackInfo),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_OBJECT_REF_INFO>((mem, ptr) => new _OBJECT_REF_INFO(mem, ptr), offsets);
        }
    }
}