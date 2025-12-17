using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_SYMBOLIC_LINK")]
    public sealed class ObjectSymbolicLink : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger CreationTime { get => ReadStructure<LargeInteger>(nameof(CreationTime)); set => WriteStructure(nameof(CreationTime), value); }

        [Offset(8UL)]
        public UnicodeString LinkTarget { get => ReadStructure<UnicodeString>(nameof(LinkTarget)); set => WriteStructure(nameof(LinkTarget), value); }

        [Offset(8UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(16UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(24UL)]
        public uint DosDeviceDriveIndex { get => ReadHere<uint>(nameof(DosDeviceDriveIndex)); set => WriteHere(nameof(DosDeviceDriveIndex), value); }

        [Offset(28UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(32UL)]
        public uint AccessMask { get => ReadHere<uint>(nameof(AccessMask)); set => WriteHere(nameof(AccessMask), value); }

        [Offset(36UL)]
        public uint IntegrityLevel { get => ReadHere<uint>(nameof(IntegrityLevel)); set => WriteHere(nameof(IntegrityLevel), value); }

        public ObjectSymbolicLink(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectSymbolicLink>();
        }
    }
}