using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECONDARY_INTERRUPT_PROVIDER_INTERFACE")]
    public sealed class SecondaryInterruptProviderInterface : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(2UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(16UL)]
        public uint GsivBase { get => ReadHere<uint>(nameof(GsivBase)); set => WriteHere(nameof(GsivBase), value); }

        [Offset(20UL)]
        public ushort GsivSize { get => ReadHere<ushort>(nameof(GsivSize)); set => WriteHere(nameof(GsivSize), value); }

        [Offset(24UL)]
        public IntPtr DriverObject { get => ReadHere<IntPtr>(nameof(DriverObject)); set => WriteHere(nameof(DriverObject), value); }

        [Offset(32UL)]
        public IntPtr Reserved1 { get => ReadHere<IntPtr>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(40UL)]
        public IntPtr Reserved2 { get => ReadHere<IntPtr>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(48UL)]
        public IntPtr Reserved3 { get => ReadHere<IntPtr>(nameof(Reserved3)); set => WriteHere(nameof(Reserved3), value); }

        [Offset(56UL)]
        public IntPtr Reserved4 { get => ReadHere<IntPtr>(nameof(Reserved4)); set => WriteHere(nameof(Reserved4), value); }

        [Offset(64UL)]
        public IntPtr Reserved5 { get => ReadHere<IntPtr>(nameof(Reserved5)); set => WriteHere(nameof(Reserved5), value); }

        [Offset(72UL)]
        public IntPtr Reserved6 { get => ReadHere<IntPtr>(nameof(Reserved6)); set => WriteHere(nameof(Reserved6), value); }

        [Offset(80UL)]
        public IntPtr Reserved7 { get => ReadHere<IntPtr>(nameof(Reserved7)); set => WriteHere(nameof(Reserved7), value); }

        public SecondaryInterruptProviderInterface(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SecondaryInterruptProviderInterface>();
        }
    }
}