using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_OBJECT_TYPE")]
    public sealed class ObjectType : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry TypeList { get => ReadStructure<ListEntry>(nameof(TypeList)); set => WriteStructure(nameof(TypeList), value); }

        [Offset(16UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(32UL)]
        public IntPtr DefaultObject { get => ReadHere<IntPtr>(nameof(DefaultObject)); set => WriteHere(nameof(DefaultObject), value); }

        [Offset(40UL)]
        public byte Index { get => ReadHere<byte>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(44UL)]
        public uint TotalNumberOfObjects { get => ReadHere<uint>(nameof(TotalNumberOfObjects)); set => WriteHere(nameof(TotalNumberOfObjects), value); }

        [Offset(48UL)]
        public uint TotalNumberOfHandles { get => ReadHere<uint>(nameof(TotalNumberOfHandles)); set => WriteHere(nameof(TotalNumberOfHandles), value); }

        [Offset(52UL)]
        public uint HighWaterNumberOfObjects { get => ReadHere<uint>(nameof(HighWaterNumberOfObjects)); set => WriteHere(nameof(HighWaterNumberOfObjects), value); }

        [Offset(56UL)]
        public uint HighWaterNumberOfHandles { get => ReadHere<uint>(nameof(HighWaterNumberOfHandles)); set => WriteHere(nameof(HighWaterNumberOfHandles), value); }

        [Offset(64UL)]
        public ObjectTypeInitializer TypeInfo { get => ReadStructure<ObjectTypeInitializer>(nameof(TypeInfo)); set => WriteStructure(nameof(TypeInfo), value); }

        [Offset(184UL)]
        public ExPushLock TypeLock { get => ReadStructure<ExPushLock>(nameof(TypeLock)); set => WriteStructure(nameof(TypeLock), value); }

        [Offset(192UL)]
        public uint Key { get => ReadHere<uint>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(200UL)]
        public ListEntry CallbackList { get => ReadStructure<ListEntry>(nameof(CallbackList)); set => WriteStructure(nameof(CallbackList), value); }

        [Offset(216UL)]
        public uint SeMandatoryLabelMask { get => ReadHere<uint>(nameof(SeMandatoryLabelMask)); set => WriteHere(nameof(SeMandatoryLabelMask), value); }

        [Offset(220UL)]
        public uint SeTrustConstraintMask { get => ReadHere<uint>(nameof(SeTrustConstraintMask)); set => WriteHere(nameof(SeTrustConstraintMask), value); }

        public ObjectType(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectType>();
        }
    }
}