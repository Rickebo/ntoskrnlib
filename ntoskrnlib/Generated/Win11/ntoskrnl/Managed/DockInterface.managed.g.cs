using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!DOCK_INTERFACE")]
    public sealed class DockInterface : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(2UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(16UL)]
        public IntPtr InterfaceReference { get => ReadHere<IntPtr>(nameof(InterfaceReference)); set => WriteHere(nameof(InterfaceReference), value); }

        [Offset(24UL)]
        public IntPtr InterfaceDereference { get => ReadHere<IntPtr>(nameof(InterfaceDereference)); set => WriteHere(nameof(InterfaceDereference), value); }

        [Offset(32UL)]
        public IntPtr ProfileDepartureSetMode { get => ReadHere<IntPtr>(nameof(ProfileDepartureSetMode)); set => WriteHere(nameof(ProfileDepartureSetMode), value); }

        [Offset(40UL)]
        public IntPtr ProfileDepartureUpdate { get => ReadHere<IntPtr>(nameof(ProfileDepartureUpdate)); set => WriteHere(nameof(ProfileDepartureUpdate), value); }

        public DockInterface(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DockInterface>();
        }
    }
}