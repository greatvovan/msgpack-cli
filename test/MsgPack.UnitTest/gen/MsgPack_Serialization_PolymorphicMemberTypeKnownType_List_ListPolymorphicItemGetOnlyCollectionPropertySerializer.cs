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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty> this_PackValueOfListPolymorphicItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfListPolymorphicItemAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>> this_SetUnpackedValueOfListPolymorphicItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int> this_UnpackValueOfListPolymorphicItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfListPolymorphicItemAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema itemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> itemsSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            itemsSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            itemsSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            itemsSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            itemsSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), itemsSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedCollection(typeof(System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>), itemsSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>(this.PackValueOfListPolymorphicItem);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListPolymorphicItemAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>>(1);
            packOperationTable["ListPolymorphicItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>(this.PackValueOfListPolymorphicItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["ListPolymorphicItem"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListPolymorphicItemAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfListPolymorphicItem);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListPolymorphicItemAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>>(1);
            unpackOperationTable["ListPolymorphicItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfListPolymorphicItem);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["ListPolymorphicItem"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListPolymorphicItemAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "ListPolymorphicItem"};
            this.this_PackValueOfListPolymorphicItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>(this.PackValueOfListPolymorphicItem);
            this.this_PackValueOfListPolymorphicItemAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListPolymorphicItemAsync);
            this.this_SetUnpackedValueOfListPolymorphicItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>>(this.SetUnpackedValueOfListPolymorphicItem);
            this.this_UnpackValueOfListPolymorphicItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfListPolymorphicItem);
            this.this_UnpackValueOfListPolymorphicItemAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListPolymorphicItemAsync);
        }
        
        private void PackValueOfListPolymorphicItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListPolymorphicItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfListPolymorphicItemAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.ListPolymorphicItem, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfListPolymorphicItem(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty unpackingContext, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry> unpackedValue) {
            System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry> existent = default(System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>);
            existent = unpackingContext.ListPolymorphicItem;
            System.Collections.Generic.IEnumerator<MsgPack.Serialization.FileSystemEntry> enumerator = unpackedValue.GetEnumerator();
            MsgPack.Serialization.FileSystemEntry current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfListPolymorphicItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>), "ListPolymorphicItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfListPolymorphicItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfListPolymorphicItemAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>), "ListPolymorphicItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfListPolymorphicItemDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemGetOnlyCollectionProperty>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
