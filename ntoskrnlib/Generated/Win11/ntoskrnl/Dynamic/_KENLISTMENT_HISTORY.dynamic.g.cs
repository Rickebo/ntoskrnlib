using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KENLISTMENT_HISTORY")]
    public sealed class _KENLISTMENT_HISTORY : DynamicStructure
    {
        public uint Notification { get; }
        public uint NewState { get; }

        public _KENLISTMENT_HISTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KENLISTMENT_HISTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KENLISTMENT_HISTORY.Notification),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KENLISTMENT_HISTORY.NewState),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_KENLISTMENT_HISTORY>((mem, ptr) => new _KENLISTMENT_HISTORY(mem, ptr), offsets);
        }
    }
}