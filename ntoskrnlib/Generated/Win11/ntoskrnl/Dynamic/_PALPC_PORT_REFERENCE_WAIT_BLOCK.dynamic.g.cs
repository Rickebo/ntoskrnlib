using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PALPC_PORT_REFERENCE_WAIT_BLOCK")]
    public sealed class _PALPC_PORT_REFERENCE_WAIT_BLOCK : DynamicStructure
    {
        public _KEVENT DesiredReferenceNoEvent { get; }
        public int DesiredReferenceNo { get; }

        public _PALPC_PORT_REFERENCE_WAIT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PALPC_PORT_REFERENCE_WAIT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PALPC_PORT_REFERENCE_WAIT_BLOCK.DesiredReferenceNoEvent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PALPC_PORT_REFERENCE_WAIT_BLOCK.DesiredReferenceNo),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_PALPC_PORT_REFERENCE_WAIT_BLOCK>((mem, ptr) => new _PALPC_PORT_REFERENCE_WAIT_BLOCK(mem, ptr), offsets);
        }
    }
}