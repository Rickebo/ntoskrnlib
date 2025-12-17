using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROFILE_PARAMETER_BLOCK")]
    public sealed class ProfileParameterBlock : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Status { get => ReadHere<ushort>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(2UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public ushort DockingState { get => ReadHere<ushort>(nameof(DockingState)); set => WriteHere(nameof(DockingState), value); }

        [Offset(6UL)]
        public ushort Capabilities { get => ReadHere<ushort>(nameof(Capabilities)); set => WriteHere(nameof(Capabilities), value); }

        [Offset(8UL)]
        public uint DockID { get => ReadHere<uint>(nameof(DockID)); set => WriteHere(nameof(DockID), value); }

        [Offset(12UL)]
        public uint SerialNumber { get => ReadHere<uint>(nameof(SerialNumber)); set => WriteHere(nameof(SerialNumber), value); }

        public ProfileParameterBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProfileParameterBlock>();
        }
    }
}