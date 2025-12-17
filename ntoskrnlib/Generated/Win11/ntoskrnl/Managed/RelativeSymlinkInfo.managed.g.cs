using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RELATIVE_SYMLINK_INFO")]
    public sealed class RelativeSymlinkInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ushort ExposedNamespaceLength { get => ReadHere<ushort>(nameof(ExposedNamespaceLength)); set => WriteHere(nameof(ExposedNamespaceLength), value); }

        [Offset(2UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public ushort DeviceNameLength { get => ReadHere<ushort>(nameof(DeviceNameLength)); set => WriteHere(nameof(DeviceNameLength), value); }

        [Offset(6UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public IntPtr InteriorMountPoint { get => ReadHere<IntPtr>(nameof(InteriorMountPoint)); set => WriteHere(nameof(InteriorMountPoint), value); }

        [Offset(16UL)]
        public UnicodeString OpenedName { get => ReadStructure<UnicodeString>(nameof(OpenedName)); set => WriteStructure(nameof(OpenedName), value); }

        public RelativeSymlinkInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RelativeSymlinkInfo>();
        }
    }
}