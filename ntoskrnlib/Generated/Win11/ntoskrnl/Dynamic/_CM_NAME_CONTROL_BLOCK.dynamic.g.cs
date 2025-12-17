using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_NAME_CONTROL_BLOCK")]
    public sealed class _CM_NAME_CONTROL_BLOCK : DynamicStructure
    {
        public uint Compressed { get; }
        public uint RefCount { get; }
        public _CM_NAME_HASH NameHash { get; }
        public _CM_COMPONENT_HASH ConvKey { get; }
        public IntPtr NextHash { get; }
        public ushort NameLength { get; }
        public short[] Name { get; }

        public _CM_NAME_CONTROL_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_NAME_CONTROL_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_NAME_CONTROL_BLOCK.Compressed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_NAME_CONTROL_BLOCK.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_NAME_CONTROL_BLOCK.NameHash),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_NAME_CONTROL_BLOCK.ConvKey),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_NAME_CONTROL_BLOCK.NextHash),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_NAME_CONTROL_BLOCK.NameLength),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CM_NAME_CONTROL_BLOCK.Name),
                    new ulong[]
                    {
                        26UL
                    }
                }
            };
            Register<_CM_NAME_CONTROL_BLOCK>((mem, ptr) => new _CM_NAME_CONTROL_BLOCK(mem, ptr), offsets);
        }
    }
}