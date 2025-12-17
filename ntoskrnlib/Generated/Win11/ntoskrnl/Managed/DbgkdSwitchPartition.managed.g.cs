using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_SWITCH_PARTITION")]
    public sealed class DbgkdSwitchPartition : DynamicStructure
    {
        [Offset(0UL)]
        public uint Partition { get => ReadHere<uint>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        public DbgkdSwitchPartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdSwitchPartition>();
        }
    }
}