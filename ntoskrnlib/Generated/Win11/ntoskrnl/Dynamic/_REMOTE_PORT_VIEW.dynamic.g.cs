using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_REMOTE_PORT_VIEW")]
    public sealed class _REMOTE_PORT_VIEW : DynamicStructure
    {
        public uint Length { get; }
        public ulong ViewSize { get; }
        public IntPtr ViewBase { get; }

        public _REMOTE_PORT_VIEW(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _REMOTE_PORT_VIEW()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_REMOTE_PORT_VIEW.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_REMOTE_PORT_VIEW.ViewSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_REMOTE_PORT_VIEW.ViewBase),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_REMOTE_PORT_VIEW>((mem, ptr) => new _REMOTE_PORT_VIEW(mem, ptr), offsets);
        }
    }
}