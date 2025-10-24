using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ntoskrnlib.Structure
{
    public abstract class DynamicStructure
    {
        private static ConcurrentBag<Action> _registerFunctions = new ConcurrentBag<Action>();
        public static IReadOnlyCollection<Action> RegisterFunction => _registerFunctions;

        private static bool RegisteredCurrent = false;

        private static readonly Dictionary<Type, DynamicStructureInfo> TypeDictionary = new Dictionary<Type, DynamicStructureInfo>();
        public static IOffsetParser OffsetParser { get; set; } = null;

        private DynamicStructureInfo StructureInfo { get; set; }

        public MemoryPointer BaseAddress { get; protected set; }
        protected IMemorySource Memory { get; }

        static DynamicStructure()
        {
            _registerFunctions.Add(DynamicArray.Register);
        }
        
        protected DynamicStructure(IMemorySource memory, MemoryPointer baseAddress)
        {
            BaseAddress = baseAddress;
            Memory = memory;

            StructureInfo = GetInfo(this.GetType());
        }
        
        public static void RegisterTypes(Assembly assembly)
        {
            if (!RegisteredCurrent)
            {
                RegisteredCurrent = true;
                RegisterTypes(typeof(DynamicStructure).Assembly);
            }

            var types = assembly.DefinedTypes;
            foreach (var type in types)
            {
                if (!typeof(DynamicStructure).IsAssignableFrom(type))
                    continue;
                
                var registerMethod = type.GetMethod("Register");

                if (registerMethod == null)
                    registerMethod = FindRegisterMethod(type);

                if (registerMethod == null || registerMethod.ContainsGenericParameters)
                    continue;

                registerMethod.Invoke(null, null);
            }
        }

        private static MethodInfo FindRegisterMethod(Type type)
        {
            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                if (method.GetParameters().Any())
                    continue;

                if (method.GetCustomAttribute<RegisterMethodAttribute>() == null)
                    continue;

                return method;
            }

            return null;
        }

        public static void EnqueueRegistration(Action registerFunction)
        {
            _registerFunctions.Add(registerFunction);
        }

        public static void RegisterQueued()
        {
            foreach (var action in _registerFunctions)
                action();
        }

        public static void Register<T>(Func<IMemorySource, MemoryPointer, T> constructorFunction = null) where T : DynamicStructure
        {
            if (GetInfo<T>() != null)
                return;

            var type = typeof(T);
            // Enforce class annotation for analysis/clarity
            if (type.GetCustomAttribute<DynamicStructureAttribute>() == null)
                throw new StructureInitializationException($"Type {type.FullName} must be annotated with [DynamicStructure].");
            var constructor = constructorFunction ?? FindConstructor<T>();

            if (constructor == null)
                throw new StructureInitializationException("Could not find constructor of type " + type);

            var info = new DynamicStructureInfo(typeof(T))
            {
                    Constructor = constructor
            };

            foreach (var property in type.GetProperties())
            {
                var attribute = property.GetCustomAttribute<Offset>();

                if (attribute == null)
                    continue;

                var offsets = attribute.Offsets;

                if (offsets == null && attribute.OffsetKeys != null)
                    offsets = OffsetParser?.Parse(attribute.OffsetKeys);

                if (offsets == null)
                    throw new StructureInitializationException(
                            "Could not resolve offsets of property " + property.Name + " from " + type + ".");

                info.OffsetDictionary.Add(property.Name, offsets);
            }

            SetInfo<T>(info);
        }

        // Zero-reflection registration: caller supplies the offset map explicitly
        public static void Register<T>(Func<IMemorySource, MemoryPointer, T> constructorFunction,
                                       IDictionary<string, ulong[]> offsets)
            where T : DynamicStructure
        {
            if (GetInfo<T>() != null)
                return;

            var type = typeof(T);
            if (type.GetCustomAttribute<DynamicStructureAttribute>() == null)
                throw new StructureInitializationException($"Type {type.FullName} must be annotated with [DynamicStructure].");
            if (constructorFunction == null)
                throw new ArgumentNullException(nameof(constructorFunction));
            if (offsets == null)
                throw new ArgumentNullException(nameof(offsets));

            var info = new DynamicStructureInfo(typeof(T))
            {
                Constructor = constructorFunction
            };

            foreach (var kv in offsets)
            {
                if (kv.Value == null || kv.Value.Length == 0)
                    throw new StructureInitializationException($"Offset list for '{kv.Key}' in {type.FullName} is null or empty.");
                info.OffsetDictionary[kv.Key] = kv.Value;
            }

            SetInfo<T>(info);
        }

        public static T Construct<T>(IMemorySource memory, MemoryPointer baseAddress) where T : DynamicStructure => 
                GetInfo<T>()?.Construct<T>(memory, baseAddress);

        private static DynamicStructureInfo GetInfo<T>() where T : DynamicStructure =>
                GetInfo(typeof(T));

        private static DynamicStructureInfo GetInfo(Type type) => 
                TypeDictionary.TryGetValue(type, out var info) ? info : null;

        public static ulong[] GetOffsets<T>(string propertyName) =>
                TypeDictionary.TryGetValue(typeof(T), out var info)
                        ? info.OffsetDictionary.TryGetValue(propertyName, out var offset)
                                ? offset
                                : null
                        : null;

        private static void SetInfo<T>(DynamicStructureInfo info) where T : DynamicStructure
        {
            TypeDictionary.Add(typeof(T), info);
        }

        private static Func<IMemorySource, MemoryPointer, T> FindConstructor<T>() where T : DynamicStructure
        {
            var type = typeof(T);
            var constructors = type.GetConstructors();

            foreach (var constructor in constructors)
            {
                if (!constructor.IsPublic)
                    continue;

                var parameters = constructor.GetParameters();
                if (parameters.Length != 2)
                    continue;

                var first = parameters[0];
                var second = parameters[1];

                if (first.ParameterType != typeof(IMemorySource))
                    continue;

                if (second.ParameterType != typeof(MemoryPointer))
                    continue;

                return (memory, memoryPtr) => (T) constructor.Invoke(new object[] { memory, memoryPtr });
            }

            return null;
        }

        protected void WriteHere<T>(T value, ulong offset = 0) where T : struct =>
            WriteHere(new ulong[] { 0 }, value, offset);

        protected void WriteHere<T>(string propertyName, T value, ulong offset = 0) where T : struct =>
            WriteHere(StructureInfo.GetOffsets(propertyName), value, offset);

        protected void WriteHere<T>(ulong[] offsets, T value, ulong offset = 0) where T : struct
        {
            if (offsets.Length != 1)
                throw new ArgumentException("Cannot write here with mor or less than one offset.", nameof(offsets));

            Memory.Write(BaseAddress + offsets[0] + offset, value);
        }

        protected T ReadHere<T>(ulong offset = 0) where T : struct =>
            ReadHere<T>(new ulong[] { 0 }, offset);

        protected T ReadHere<T>(string propertyName, ulong offset = 0) where T : struct =>
            ReadHere<T>(StructureInfo.GetOffsets(propertyName), offset);

        protected T ReadHere<T>(ulong[] offsets, ulong offset = 0) where T : struct =>
            offsets.Length == 1
                ? Memory.Read<T>(BaseAddress + offsets[0] + offset)
                : throw new ArgumentException("Cannot read structure here with more or less than one offset.", nameof(offsets));

        protected T ReadStructureHere<T>(ulong offset = 0) where T : DynamicStructure =>
            ReadStructureHere<T>(new ulong[] { 0 }, offset);

        protected T ReadStructureHere<T>(string propertyName, ulong offset = 0) where T : DynamicStructure =>
            ReadStructureHere<T>(StructureInfo.GetOffsets(propertyName), offset);

        protected T ReadStructureHere<T>(ulong[] offsets, ulong offset = 0) where T : DynamicStructure =>
            offsets.Length == 1
                ? Memory.ReadStructure<T>(BaseAddress + offsets[0] + offset)
                : throw new ArgumentException("Cannot read structure here with more or less than one offset.", nameof(offsets));


        protected void Write<T>(string propertyName, T value) where T : struct =>
            Write<T>(StructureInfo.GetOffsets(propertyName), value);

        protected void Write<T>(ulong[] offsets, T value) where T : struct =>
            Memory.Write<T>(Dereference(offsets), value);

        protected T Read<T>(string propertyName) where T : struct =>
                Read<T>(StructureInfo.GetOffsets(propertyName));

        protected T Read<T>(ulong[] offsets) where T : struct => 
                Memory.Read<T>(Dereference(offsets));

        protected T ReadStructure<T>(string propertyName) where T : DynamicStructure =>
                ReadStructure<T>(StructureInfo.GetOffsets(propertyName));
        
        protected T ReadStructure<T>(ulong[] offsets) where T : DynamicStructure
        {
            if (offsets.Length < 1)
                throw new ArgumentException("At least one offset must be specified in order to read.", nameof(offsets));
            
            return Memory.ReadStructure<T>(Dereference(offsets, finalDereference: true));
        }

        private MemoryPointer Dereference(IEnumerable<ulong> offsets, bool finalDereference = false)
        {
            var ptr = BaseAddress;
            var isFirst = true;

            foreach (var offset in offsets)
            {
                if (!isFirst)
                    ptr = Memory.Read<MemoryPointer>(ptr);
                else
                    isFirst = false;

                ptr += offset;
            }

            if (finalDereference)
                ptr = Memory.Read<MemoryPointer>(ptr);

            return ptr;
        }

        protected T ReadStructure<T>(uint offset) where T : DynamicStructure =>
                Memory.ReadStructure<T>(BaseAddress + offset);

        private class DynamicStructureInfo
        {
            private readonly Type _type;
            public object Constructor { get; set; }
            public Dictionary<string, ulong[]> OffsetDictionary { get; } = new Dictionary<string, ulong[]>();

            public DynamicStructureInfo(Type type)
            {
                _type = type;
            }

            public Func<IMemorySource, MemoryPointer, T> GetConstructor<T>() where T : DynamicStructure
            {
                if (typeof(T) != _type)
                    throw new ArgumentException("Cannot get converter of another type.");

                return (Func<IMemorySource, MemoryPointer, T>) Constructor;
            }

            public T Construct<T>(IMemorySource memory, MemoryPointer baseAddress) where T : DynamicStructure =>
                    GetConstructor<T>()(memory, baseAddress);

            public ulong[] GetOffsets(string propertyName) =>
                    OffsetDictionary[propertyName];
        }
    }
}
