﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeWithOneBaseOrderSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithOneBaseOrder> {
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder> this_PackMemberPlaceHolderDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder> this_PackValueOfOneDelegate;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder> this_PackValueOfTwoDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackMemberPlaceHolderAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfOneAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfTwoAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int> this_UnpackMemberPlaceHolderDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int> this_SetUnpackedValueOfOneDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, int> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int> this_UnpackValueOfOneDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int> this_SetUnpackedValueOfTwoDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int> this_UnpackValueOfTwoDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackMemberPlaceHolderAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfOneAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfTwoAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_ComplexTypeWithOneBaseOrderSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackMemberPlaceHolder);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackValueOfOne);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackValueOfTwo);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>[3];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackMemberPlaceHolderAsync);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfOneAsync);
            packOperationListAsync[2] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTwoAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>>(2);
            packOperationTable["One"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackValueOfOne);
            packOperationTable["Two"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackValueOfTwo);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(2);
            packOperationTableAsync["One"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfOneAsync);
            packOperationTableAsync["Two"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTwoAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackMemberPlaceHolder);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackValueOfOne);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackValueOfTwo);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[3];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackMemberPlaceHolderAsync);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfOneAsync);
            unpackOperationListAsync[2] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTwoAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>>(2);
            unpackOperationTable["One"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackValueOfOne);
            unpackOperationTable["Two"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackValueOfTwo);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(2);
            unpackOperationTableAsync["One"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfOneAsync);
            unpackOperationTableAsync["Two"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTwoAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    null,
                    "One",
                    "Two"};
            this.this_PackMemberPlaceHolderDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackMemberPlaceHolder);
            this.this_PackValueOfOneDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackValueOfOne);
            this.this_PackValueOfTwoDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(this.PackValueOfTwo);
            this.this_PackMemberPlaceHolderAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackMemberPlaceHolderAsync);
            this.this_PackValueOfOneAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfOneAsync);
            this.this_PackValueOfTwoAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTwoAsync);
            this.this_UnpackMemberPlaceHolderDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackMemberPlaceHolder);
            this.this_SetUnpackedValueOfOneDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int>(this.SetUnpackedValueOfOne);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, int>(MsgPack.Serialization.UnpackHelpers.UnpackInt32Value);
            this.this_UnpackValueOfOneDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackValueOfOne);
            this.this_SetUnpackedValueOfTwoDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int>(this.SetUnpackedValueOfTwo);
            this.this_UnpackValueOfTwoDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int>(this.UnpackValueOfTwo);
            this.this_UnpackMemberPlaceHolderAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackMemberPlaceHolderAsync);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>>(MsgPack.Serialization.UnpackHelpers.UnpackInt32ValueAsync);
            this.this_UnpackValueOfOneAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfOneAsync);
            this.this_UnpackValueOfTwoAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTwoAsync);
        }
        
        private void PackMemberPlaceHolder(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree) {
            packer.PackNull();
        }
        
        private void PackValueOfOne(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree) {
            this._serializer0.PackTo(packer, objectTree.One);
        }
        
        private void PackValueOfTwo(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree) {
            this._serializer0.PackTo(packer, objectTree.Two);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackMemberPlaceHolderAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            return packer.PackNullAsync(cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfOneAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.One, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfTwoAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Two, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void UnpackMemberPlaceHolder(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int indexOfItem, int itemsCount) {
            unpacker.Read();
        }
        
        private void SetUnpackedValueOfOne(MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int unpackedValue) {
            unpackingContext.One = unpackedValue;
        }
        
        private void UnpackValueOfOne(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(int), "One", this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate, this.this_SetUnpackedValueOfOneDelegate);
        }
        
        private void SetUnpackedValueOfTwo(MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int unpackedValue) {
            unpackingContext.Two = unpackedValue;
        }
        
        private void UnpackValueOfTwo(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(int), "Two", this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate, this.this_SetUnpackedValueOfTwoDelegate);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithOneBaseOrder UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithOneBaseOrder result = default(MsgPack.Serialization.ComplexTypeWithOneBaseOrder);
            result = new MsgPack.Serialization.ComplexTypeWithOneBaseOrder();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackMemberPlaceHolderAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return unpacker.ReadAsync(cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfOneAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(int), "One", this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate, this.this_SetUnpackedValueOfOneDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTwoAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithOneBaseOrder unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(int), "Two", this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate, this.this_SetUnpackedValueOfTwoDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.ComplexTypeWithOneBaseOrder> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.ComplexTypeWithOneBaseOrder result = default(MsgPack.Serialization.ComplexTypeWithOneBaseOrder);
            result = new MsgPack.Serialization.ComplexTypeWithOneBaseOrder();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithOneBaseOrder>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
