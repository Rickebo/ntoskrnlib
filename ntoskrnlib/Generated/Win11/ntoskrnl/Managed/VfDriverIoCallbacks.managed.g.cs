using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_DRIVER_IO_CALLBACKS")]
    public sealed class VfDriverIoCallbacks : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DriverInit { get => ReadHere<IntPtr>(nameof(DriverInit)); set => WriteHere(nameof(DriverInit), value); }

        [Offset(8UL)]
        public IntPtr DriverStartIo { get => ReadHere<IntPtr>(nameof(DriverStartIo)); set => WriteHere(nameof(DriverStartIo), value); }

        [Offset(16UL)]
        public IntPtr DriverUnload { get => ReadHere<IntPtr>(nameof(DriverUnload)); set => WriteHere(nameof(DriverUnload), value); }

        [Offset(24UL)]
        public IntPtr AddDevice { get => ReadHere<IntPtr>(nameof(AddDevice)); set => WriteHere(nameof(AddDevice), value); }

        [Offset(32UL)]
        [Length(28)]
        public DynamicArray MajorFunction { get => ReadStructure<DynamicArray>(nameof(MajorFunction)); set => WriteStructure(nameof(MajorFunction), value); }

        public VfDriverIoCallbacks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfDriverIoCallbacks>();
        }
    }
}