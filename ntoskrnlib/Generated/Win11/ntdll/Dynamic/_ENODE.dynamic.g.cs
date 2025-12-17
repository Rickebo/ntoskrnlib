using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ENODE")]
    public sealed class _ENODE : DynamicStructure
    {
        public _KNODE Ncb { get; }
        public _WORK_QUEUE_ITEM HotAddProcessorWorkItem { get; }

        public _ENODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ENODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ENODE.Ncb),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ENODE.HotAddProcessorWorkItem),
                    new ulong[]
                    {
                        376UL
                    }
                }
            };
            Register<_ENODE>((mem, ptr) => new _ENODE(mem, ptr), offsets);
        }
    }
}