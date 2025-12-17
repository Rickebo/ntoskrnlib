using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_REMOVE_LOCK")]
    public sealed class IoRemoveLock : DynamicStructure
    {
        [Offset(0UL)]
        public IoRemoveLockCommonBlock Common { get => ReadStructure<IoRemoveLockCommonBlock>(nameof(Common)); set => WriteStructure(nameof(Common), value); }

        public IoRemoveLock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoRemoveLock>();
        }
    }
}