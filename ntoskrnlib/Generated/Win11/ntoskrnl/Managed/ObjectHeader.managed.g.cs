using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER")]
    public sealed class ObjectHeader : DynamicStructure
    {
        [Offset(0UL)]
        public long PointerCount { get => ReadHere<long>(nameof(PointerCount)); set => WriteHere(nameof(PointerCount), value); }

        [Offset(8UL)]
        public long HandleCount { get => ReadHere<long>(nameof(HandleCount)); set => WriteHere(nameof(HandleCount), value); }

        [Offset(8UL)]
        public IntPtr NextToFree { get => ReadHere<IntPtr>(nameof(NextToFree)); set => WriteHere(nameof(NextToFree), value); }

        [Offset(16UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(24UL)]
        public byte TypeIndex { get => ReadHere<byte>(nameof(TypeIndex)); set => WriteHere(nameof(TypeIndex), value); }

        [Offset(25UL)]
        public byte TraceFlags { get => ReadHere<byte>(nameof(TraceFlags)); set => WriteHere(nameof(TraceFlags), value); }

        [Offset(25UL)]
        public byte DbgRefTrace { get => ReadHere<byte>(nameof(DbgRefTrace)); set => WriteHere(nameof(DbgRefTrace), value); }

        [Offset(25UL)]
        public byte DbgTracePermanent { get => ReadHere<byte>(nameof(DbgTracePermanent)); set => WriteHere(nameof(DbgTracePermanent), value); }

        [Offset(26UL)]
        public byte InfoMask { get => ReadHere<byte>(nameof(InfoMask)); set => WriteHere(nameof(InfoMask), value); }

        [Offset(27UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(27UL)]
        public byte NewObject { get => ReadHere<byte>(nameof(NewObject)); set => WriteHere(nameof(NewObject), value); }

        [Offset(27UL)]
        public byte KernelObject { get => ReadHere<byte>(nameof(KernelObject)); set => WriteHere(nameof(KernelObject), value); }

        [Offset(27UL)]
        public byte KernelOnlyAccess { get => ReadHere<byte>(nameof(KernelOnlyAccess)); set => WriteHere(nameof(KernelOnlyAccess), value); }

        [Offset(27UL)]
        public byte ExclusiveObject { get => ReadHere<byte>(nameof(ExclusiveObject)); set => WriteHere(nameof(ExclusiveObject), value); }

        [Offset(27UL)]
        public byte PermanentObject { get => ReadHere<byte>(nameof(PermanentObject)); set => WriteHere(nameof(PermanentObject), value); }

        [Offset(27UL)]
        public byte DefaultSecurityQuota { get => ReadHere<byte>(nameof(DefaultSecurityQuota)); set => WriteHere(nameof(DefaultSecurityQuota), value); }

        [Offset(27UL)]
        public byte SingleHandleEntry { get => ReadHere<byte>(nameof(SingleHandleEntry)); set => WriteHere(nameof(SingleHandleEntry), value); }

        [Offset(27UL)]
        public byte DeletedInline { get => ReadHere<byte>(nameof(DeletedInline)); set => WriteHere(nameof(DeletedInline), value); }

        [Offset(28UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(32UL)]
        public IntPtr ObjectCreateInfo { get => ReadHere<IntPtr>(nameof(ObjectCreateInfo)); set => WriteHere(nameof(ObjectCreateInfo), value); }

        [Offset(32UL)]
        public IntPtr QuotaBlockCharged { get => ReadHere<IntPtr>(nameof(QuotaBlockCharged)); set => WriteHere(nameof(QuotaBlockCharged), value); }

        [Offset(40UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        [Offset(48UL)]
        public Quad Body { get => ReadStructure<Quad>(nameof(Body)); set => WriteStructure(nameof(Body), value); }

        public ObjectHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeader>();
        }
    }
}