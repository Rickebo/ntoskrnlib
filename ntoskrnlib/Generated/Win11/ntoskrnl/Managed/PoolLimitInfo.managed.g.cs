using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POOL_LIMIT_INFO")]
    public sealed class PoolLimitInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ulong HardMemoryLimit { get => ReadHere<ulong>(nameof(HardMemoryLimit)); set => WriteHere(nameof(HardMemoryLimit), value); }

        [Offset(8UL)]
        public ulong NotificationLimit { get => ReadHere<ulong>(nameof(NotificationLimit)); set => WriteHere(nameof(NotificationLimit), value); }

        [Offset(16UL)]
        public ulong MemoryIssued { get => ReadHere<ulong>(nameof(MemoryIssued)); set => WriteHere(nameof(MemoryIssued), value); }

        public PoolLimitInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoolLimitInfo>();
        }
    }
}