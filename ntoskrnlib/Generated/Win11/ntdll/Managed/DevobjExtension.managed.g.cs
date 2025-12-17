using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DEVOBJ_EXTENSION")]
    public sealed class DevobjExtension : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(16UL)]
        public uint PowerFlags { get => ReadHere<uint>(nameof(PowerFlags)); set => WriteHere(nameof(PowerFlags), value); }

        [Offset(24UL)]
        public IntPtr Dope { get => ReadHere<IntPtr>(nameof(Dope)); set => WriteHere(nameof(Dope), value); }

        [Offset(32UL)]
        public uint ExtensionFlags { get => ReadHere<uint>(nameof(ExtensionFlags)); set => WriteHere(nameof(ExtensionFlags), value); }

        [Offset(40UL)]
        public IntPtr DeviceNode { get => ReadHere<IntPtr>(nameof(DeviceNode)); set => WriteHere(nameof(DeviceNode), value); }

        [Offset(48UL)]
        public IntPtr AttachedTo { get => ReadHere<IntPtr>(nameof(AttachedTo)); set => WriteHere(nameof(AttachedTo), value); }

        [Offset(56UL)]
        public int StartIoCount { get => ReadHere<int>(nameof(StartIoCount)); set => WriteHere(nameof(StartIoCount), value); }

        [Offset(60UL)]
        public int StartIoKey { get => ReadHere<int>(nameof(StartIoKey)); set => WriteHere(nameof(StartIoKey), value); }

        [Offset(64UL)]
        public uint StartIoFlags { get => ReadHere<uint>(nameof(StartIoFlags)); set => WriteHere(nameof(StartIoFlags), value); }

        [Offset(72UL)]
        public IntPtr Vpb { get => ReadHere<IntPtr>(nameof(Vpb)); set => WriteHere(nameof(Vpb), value); }

        [Offset(80UL)]
        public IntPtr DependencyNode { get => ReadHere<IntPtr>(nameof(DependencyNode)); set => WriteHere(nameof(DependencyNode), value); }

        [Offset(88UL)]
        public IntPtr InterruptContext { get => ReadHere<IntPtr>(nameof(InterruptContext)); set => WriteHere(nameof(InterruptContext), value); }

        [Offset(96UL)]
        public int InterruptCount { get => ReadHere<int>(nameof(InterruptCount)); set => WriteHere(nameof(InterruptCount), value); }

        [Offset(104UL)]
        public IntPtr VerifierContext { get => ReadHere<IntPtr>(nameof(VerifierContext)); set => WriteHere(nameof(VerifierContext), value); }

        public DevobjExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DevobjExtension>();
        }
    }
}