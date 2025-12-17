using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CMSI_RW_LOCK")]
    public sealed class CmsiRwLock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Reserved { get => ReadHere<IntPtr>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public CmsiRwLock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmsiRwLock>();
        }
    }
}