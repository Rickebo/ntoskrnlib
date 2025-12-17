using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_POLICY_DEVICE")]
    public sealed class PopPolicyDevice : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public uint DeviceType { get => ReadHere<uint>(nameof(DeviceType)); set => WriteHere(nameof(DeviceType), value); }

        [Offset(24UL)]
        public IntPtr Notification { get => ReadHere<IntPtr>(nameof(Notification)); set => WriteHere(nameof(Notification), value); }

        [Offset(32UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(48UL)]
        public IntPtr Device { get => ReadHere<IntPtr>(nameof(Device)); set => WriteHere(nameof(Device), value); }

        [Offset(56UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        public PopPolicyDevice(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopPolicyDevice>();
        }
    }
}