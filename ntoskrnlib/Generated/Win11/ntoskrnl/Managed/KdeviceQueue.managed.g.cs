using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KDEVICE_QUEUE")]
    public sealed class KdeviceQueue : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public ListEntry DeviceListHead { get => ReadStructure<ListEntry>(nameof(DeviceListHead)); set => WriteStructure(nameof(DeviceListHead), value); }

        [Offset(24UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(32UL)]
        public byte Busy { get => ReadHere<byte>(nameof(Busy)); set => WriteHere(nameof(Busy), value); }

        [Offset(32UL)]
        public long Reserved { get => ReadHere<long>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(32UL)]
        public long Hint { get => ReadHere<long>(nameof(Hint)); set => WriteHere(nameof(Hint), value); }

        public KdeviceQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KdeviceQueue>();
        }
    }
}