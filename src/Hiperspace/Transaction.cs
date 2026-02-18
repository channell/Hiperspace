// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace;
using ProtoBuf;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    public abstract partial class HiperSpace
    {
        public class Transaction : IDisposable
        {
            public enum StateType
            {
                Begin = 0,
                Commit = 1,
                Rollback = 2,
                Complete = 4,
            }

            public StateType State { get; private set; }
            public Guid Id { get; private set; }
            private HiperSpace _space;
            internal Transaction(HiperSpace space)
            {
                _space = space;
                Id = Guid.NewGuid();
                State = StateType.Begin;
            }

            public void Commit ()
            {
                State = StateType.Commit;
                _space.CompleteTransaction(this);
            }
            public void Rollback()
            {
                State = StateType.Commit;
                _space.CompleteTransaction(this);
            }

            public void Dispose()
            {
                State = State | StateType.Complete;
                _space.CompleteTransaction(this);
            }
        }
    }
}
 
namespace Hiperspace
{

    #region Transaction


    [ProtoContract]
    [Hiperspace.Element(false, "Transactions")]
    public partial class Transaction : Hiperspace.Element<Transaction>
    {
        internal KeyType _key;
        internal ValueType _value;

        public Transaction()
        {
            _key = new KeyType();
            _value = new ValueType();




        }
        internal Transaction(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;

        }

        internal Transaction(KeyType key) : this()
        {
            _key = key;
        }

        public Transaction(Transaction source, SubSpace? space = null) : this()
        {
            _key = source._key;
            _value = source._value;

            if (space is not null)
                Bind(space);
        }


        [ProtoMember(1)]
        public Guid? Id
        {
            get
            {
                return _key.Id;
            }
            set
            {
                if (SetSpace is not null && _key.Id != value) throw new Hiperspace.ValueMutationException($"Id");
                _key.Id = value;
            }
        }


        [ProtoMember(2)]
        public Hiperspace.TransactionState? State
        {
            get
            {
                return _value.State;
            }
            set
            {
                if (SetSpace is not null && _value.State != value) throw new Hiperspace.ValueMutationException($"State");
                _value.State = value;
            }
        }

        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {

            internal KeyType(Transaction item)
            {

                Id = item.Id;
            }

            [ProtoMember(1)] public Guid? Id;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsGetable()
            {

                if (Id is null || Id == default) return false;
                return true;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsSargable()
            {

                if (Id is not null && Id != default) return true;
                return false;
            }
            public string SKey => throw new NotImplementedException();
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

            }
            public bool Equals(KeyType other)
            {
                if (this == other) return true;
                return false;
            }
            public override bool Equals(Object? other)
            {
                if (other is null) return false;
                if (other is KeyType) return Equals((KeyType)other);
                return false;
            }

            public override int GetHashCode()
            {
                HashCode hc = new HashCode();

                hc.Add(Id);
                return hc.ToHashCode();
            }

            public int CompareTo(KeyType other)
            {
                if (this < other) return -1;
                if (this > other) return 1;
                return 0;
            }
            public static bool operator ==(KeyType left, KeyType right)
            {

                if (left.Id?.Equals(right.Id) == false) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {

                if (left.Id < right.Id) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {

                if (left.Id > right.Id) return true;
                return false;
            }

            internal KeyRef<KeyType, Transaction> self { get => new KeyRef<KeyType, Transaction>(this); }

            public static implicit operator KeyRef<KeyType, Transaction>([NotNull] KeyType other)
            {
                return other.self;
            }
        }
        public static explicit operator KeyType(Transaction item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            internal ValueType(Transaction item)
            {

                State = item.State;
            }

            [ProtoMember(2)] public Hiperspace.TransactionState? State;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

            }
            public override int GetHashCode()
            {
                HashCode hc = new HashCode();

                hc.Add(State);
                return hc.ToHashCode();
            }
        }
        public static explicit operator ValueType(Transaction item) => item._value;

        #endregion

        #region views
        public override T? Cast<T>() where T : class
        {

            if (this is T t)
                return t;
            return null;
        }


        #endregion

        #region Entity

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void PreBind()
        {


        }

        private int? _hashCode;
        public override int GetHashCode()
        {
            if (SetSpace is not null)
            {
                if (_hashCode.HasValue) return _hashCode.Value;
                _hashCode = _key.GetHashCode();
                return _hashCode.Value;
            }
            else
                return _key.GetHashCode();
        }
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is Transaction) return Equals((Transaction)other);
            return false;
        }
        public override bool Equals(Transaction? other)
        {
            if (other is null)
                return false;
            return (_key == other._key);
        }
        public override int CompareTo(Transaction? other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));
            if (_key < other._key)
                return -1;
            else if (_key > other._key)
                return 1;
            else
                return 0;
        }

        #endregion
        #region helpers
        public KeyRef<Transaction.KeyType, Transaction> self { get => new KeyRef<Transaction.KeyType, Transaction>(_key, this); }
        public override string SKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static implicit operator KeyRef<KeyType, Transaction>([NotNull] Transaction other)
        {
            return other.self;
        }
        public static implicit operator KeyRef<KeyType, Transaction>?(Transaction? other)
        {
            if (other is not null)
                return other.self;
            return null;
        }
        internal bool Filter(Transaction other, bool read)
        {

            if (other._key.Id is not null && this._key.Id is not null && this._key.Id != other._key.Id) return false;

            if (other._value.State is not null && this._value.State is not null && this._value.State != other._value.State) return false;
            return true;
        }
        public override bool BindKey<TKey>(TKey key)
        {
            if (key is KeyType kt && kt.IsSargable())
            {
                _key = kt;
                return true;
            }
            return false;
        }

        public override Result<Transaction> Bind(SubSpace subSpace)
        {
            throw new NotImplementedException();
        }

        public override void Unbind(SubSpace subSpace)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Transaction? left, Transaction? right)
        {
            if (left is null && right is null)
                return true;
            else if (left is null || right is null)
                return false;
            else
                return left.Equals(right);
        }
        public static bool operator !=(Transaction? left, Transaction? right)
        {
            if (left is null && right is null)
                return false;
            else if (left is null || right is null)
                return true;
            else
                return !left.Equals(right);
        }

        #endregion

    }
    #endregion
}