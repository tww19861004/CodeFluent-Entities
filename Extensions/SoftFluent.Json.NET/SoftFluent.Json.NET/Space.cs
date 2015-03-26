﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Json.NET
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 23 February 2015 11:33.
    // Build:1.0.61214.0803
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0803")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Name={Name}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    [Newtonsoft.Json.JsonObjectAttribute(MemberSerialization=Newtonsoft.Json.MemberSerialization.OptIn)]
    public partial class Space : System.ICloneable, System.IComparable, System.IComparable<SoftFluent.Json.NET.Space>, CodeFluent.Runtime.ICodeFluentCollectionEntity<string>, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<SoftFluent.Json.NET.Space>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private byte[] _rowVersion;
        
        private int _id = -1;
        
        private string _name = default(string);
        
        private string _description = default(string);
        
        private float _width = CodeFluentPersistence.DefaultSingleValue;
        
        private float _height = CodeFluentPersistence.DefaultSingleValue;
        
        private float _tVA = CodeFluentPersistence.DefaultSingleValue;
        
        private decimal _price = CodeFluentPersistence.DefaultDecimalValue;
        
        [System.NonSerializedAttribute()]
        [Newtonsoft.Json.JsonIgnoreAttribute()]
        private SoftFluent.Json.NET.SupportCollection _support;
        
        public Space()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.Id.ToString();
            }
            set
            {
                this.Id = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.Name;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        [System.ComponentModel.DataObjectFieldAttribute(false, true)]
        [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.ByteArrayConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return this._rowVersion;
            }
            set
            {
                if (((value != null) 
                            && (value.Length == 0)))
                {
                    value = null;
                }
                this._rowVersion = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("RowVersion"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<string>.Default.Equals(value, this._name) == true))
                {
                    return;
                }
                string oldKey = this._name;
                this._name = value;
                try
                {
                    this.OnCollectionKeyChanged(oldKey);
                }
                catch (System.ArgumentException )
                {
                    this._name = oldKey;
                    return;
                }
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Name"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Description"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultSingleValue)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(float))]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public float Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Width"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultSingleValue)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(float))]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public float Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Height"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(CodeFluentPersistence.DefaultSingleValue)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(float))]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public float TVA
        {
            get
            {
                return this._tVA;
            }
            set
            {
                this._tVA = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("TVA"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(decimal))]
        [Newtonsoft.Json.JsonPropertyAttribute()]
        public decimal Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Price"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonIgnoreAttribute()]
        public SoftFluent.Json.NET.SupportCollection Support
        {
            get
            {
                if ((this._support == null))
                {
                    if (((this.Id == -1) 
                                || (this.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) == true)))
                    {
                        this._support = new SoftFluent.Json.NET.SupportCollection(this);
                        return this._support;
                    }
                    this._support = SoftFluent.Json.NET.SupportCollection.LoadSupportSpacesBySpace(this);
                }
                return this._support;
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        string CodeFluent.Runtime.Utilities.IKeyable<System.String>.Key
        {
            get
            {
                return this.Name;
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                if (((this._entityState == CodeFluent.Runtime.CodeFluentEntityState.Created) 
                            && (value == CodeFluent.Runtime.CodeFluentEntityState.Modified)))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        [field:System.NonSerializedAttribute()]
        public event System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<string>> KeyChanged;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(SoftFluent.Json.NET.Space space)
        {
            if ((space == null))
            {
                return false;
            }
            if ((this.Id == -1))
            {
                return base.Equals(space);
            }
            return (this.Id.Equals(space.Id) == true);
        }
        
        public override int GetHashCode()
        {
            return this._id;
        }
        
        public override bool Equals(object obj)
        {
            SoftFluent.Json.NET.Space space = null;
			space = obj as SoftFluent.Json.NET.Space;
            return this.Equals(space);
        }
        
        internal void SaveSupportRelations()
        {
            if ((this._support == null))
            {
                return;
            }
            System.Collections.IEnumerator enumerator = ((CodeFluent.Runtime.ICodeFluentSet)(this._support)).Relations.GetEnumerator();
            bool b;
            for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
            {
                System.Collections.DictionaryEntry entry = ((System.Collections.DictionaryEntry)(enumerator.Current));
                SoftFluent.Json.NET.Support support = ((SoftFluent.Json.NET.Support)(entry.Key));
                CodeFluent.Runtime.CodeFluentRelationType relationType = ((CodeFluent.Runtime.CodeFluentRelationType)(entry.Value));
                if (((relationType == CodeFluent.Runtime.CodeFluentRelationType.Added) 
                            && ((support.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeUnlinked) 
                            == false)))
                {
                    CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Json.NET.Constants.SoftFluent_Json_NETStoreName).Persistence;
                    persistence.CreateStoredProcedureCommand(null, "Support", "SaveSpaceSupport");
                    persistence.AddParameter("@Space_Id", this.Id, ((int)(-1)));
                    persistence.AddParameter("@Support_Id", support.Id, ((int)(-1)));
                    persistence.ExecuteNonQuery();
                }
                else
                {
                    CodeFluent.Runtime.CodeFluentPersistence persistence1 = CodeFluentContext.Get(SoftFluent.Json.NET.Constants.SoftFluent_Json_NETStoreName).Persistence;
                    persistence1.CreateStoredProcedureCommand(null, "Support", "DeleteSpaceSupport");
                    persistence1.AddParameter("@Space_Id", this.Id, ((int)(-1)));
                    persistence1.AddParameter("@Support_Id", support.Id, ((int)(-1)));
                    persistence1.ExecuteNonQuery();
                }
                if ((support.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeUnlinked))
                {
                    support.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                }
            }
            ((CodeFluent.Runtime.ICodeFluentSet)(this._support)).Relations.Clear();
        }
        
        int System.IComparable.CompareTo(object value)
        {
            SoftFluent.Json.NET.Space space = null;
space = value as SoftFluent.Json.NET.Space;
            if ((space == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(space);
            return localCompareTo;
        }
        
        public virtual int CompareTo(SoftFluent.Json.NET.Space space)
        {
            if ((space == null))
            {
                throw new System.ArgumentNullException("space");
            }
            int localCompareTo = this.Name.CompareTo(space.Name);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = SoftFluent.Json.NET.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Json.NET.Space.ExternalValidate", "Type \'SoftFluent.Json.NET.Space\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            if ((this.Name == default(string)))
            {
                string localValidate = SoftFluent.Json.NET.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Json.NET.Space.Name.NullException", "\'Name\' property cannot be set to \'\' for type \'SoftFluent.Json.NET.Space\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate);
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            if ((this.RowVersion == null))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Json.NET.Constants.SoftFluent_Json_NETStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Space", "Delete");
            persistence.AddParameter("@Space_Id", this.Id, ((int)(-1)));
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._id = CodeFluentPersistence.GetReaderValue(reader, "Space_Id", ((int)(-1)));
                this._name = CodeFluentPersistence.GetReaderValue(reader, "Space_Name", ((string)(default(string))));
                this._description = CodeFluentPersistence.GetReaderValue(reader, "Space_Description", ((string)(default(string))));
                this._width = CodeFluentPersistence.GetReaderValue(reader, "Space_Width", ((float)(CodeFluentPersistence.DefaultSingleValue)));
                this._height = CodeFluentPersistence.GetReaderValue(reader, "Space_Height", ((float)(CodeFluentPersistence.DefaultSingleValue)));
                this._tVA = CodeFluentPersistence.GetReaderValue(reader, "Space_TVA", ((float)(CodeFluentPersistence.DefaultSingleValue)));
                this._price = CodeFluentPersistence.GetReaderValue(reader, "Space_Price", ((decimal)(CodeFluentPersistence.DefaultDecimalValue)));
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.RowVersion) 
                        == 0) 
                        == false))
            {
                this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._id = CodeFluentPersistence.GetReaderValue(reader, "Space_Id", ((int)(-1)));
            this._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", ((byte[])(null)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Json.NET.Space Load(int id)
        {
            if ((id == -1))
            {
                return null;
            }
            SoftFluent.Json.NET.Space space = new SoftFluent.Json.NET.Space();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Json.NET.Constants.SoftFluent_Json_NETStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Space", "Load");
            persistence.AddParameter("@Id", id, ((int)(-1)));
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    space.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    space.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return space;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
        public static SoftFluent.Json.NET.Space LoadByName(string name)
        {
            if ((name == default(string)))
            {
                return null;
            }
            SoftFluent.Json.NET.Space space = new SoftFluent.Json.NET.Space();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Json.NET.Constants.SoftFluent_Json_NETStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Space", "LoadByName");
            persistence.AddParameter("@Name", name, default(string));
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    space.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    space.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return space;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.Id == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Json.NET.Constants.SoftFluent_Json_NETStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Space", "Load");
            persistence.AddParameter("@Id", this.Id, ((int)(-1)));
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Json.NET.Constants.SoftFluent_Json_NETStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Space", "Save");
            persistence.AddParameter("@Space_Id", this.Id, ((int)(-1)));
            persistence.AddParameter("@Space_Name", this.Name, default(string));
            persistence.AddParameter("@Space_Description", this.Description, default(string));
            persistence.AddParameter("@Space_Width", this.Width, CodeFluentPersistence.DefaultSingleValue);
            persistence.AddParameter("@Space_Height", this.Height, CodeFluentPersistence.DefaultSingleValue);
            persistence.AddParameter("@Space_TVA", this.TVA, CodeFluentPersistence.DefaultSingleValue);
            persistence.AddParameter("@Space_Price", this.Price, CodeFluentPersistence.DefaultDecimalValue);
            persistence.AddParameter("@_trackLastWriteUser", persistence.Context.User.Name);
            persistence.AddParameter("@_rowVersion", this.RowVersion);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.SaveSupportRelations();
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(SoftFluent.Json.NET.Space space)
        {
            if ((space == null))
            {
                return false;
            }
            bool ret = space.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(SoftFluent.Json.NET.Space space)
        {
            bool ret = SoftFluent.Json.NET.Space.Save(space);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(SoftFluent.Json.NET.Space space)
        {
            if ((space == null))
            {
                return false;
            }
            bool ret = space.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("Id=");
            writer.Write(this.Id);
            writer.Write(",");
            writer.Write("Name=");
            writer.Write(this.Name);
            writer.Write(",");
            writer.Write("Description=");
            writer.Write(this.Description);
            writer.Write(",");
            writer.Write("Width=");
            writer.Write(this.Width);
            writer.Write(",");
            writer.Write("Height=");
            writer.Write(this.Height);
            writer.Write(",");
            writer.Write("TVA=");
            writer.Write(this.TVA);
            writer.Write(",");
            writer.Write("Price=");
            writer.Write(this.Price);
            writer.Write(",");
            writer.Write("Support=");
            if ((this._support != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._support)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        public virtual void SetSupport(System.Collections.IDictionary values)
        {
            if ((values == null))
            {
                throw new System.ArgumentNullException("values");
            }
            this.Support.Clear();
            System.Collections.IEnumerator enumerator = values.GetEnumerator();
            bool b;
            for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
            {
                System.Collections.DictionaryEntry entry = ((System.Collections.DictionaryEntry)(enumerator.Current));
                if ((entry.Key != null))
                {
                    this.Support.AddByEntityKey(entry.Key.ToString());
                }
            }
        }
        
        public virtual void SetSupport(object values)
        {
            if ((values == null))
            {
                return;
            }
            System.Collections.IDictionary dictionary = null;
dictionary = values as System.Collections.IDictionary;
            if ((dictionary != null))
            {
                this.SetSupport(dictionary);
                return;
            }
            SoftFluent.Json.NET.SupportCollection support = null;
support = values as SoftFluent.Json.NET.SupportCollection;
            if ((support != null))
            {
                this._support = support;
                return;
            }
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Json.NET.Space LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            SoftFluent.Json.NET.Space space;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            space = SoftFluent.Json.NET.Space.Load(var);
            return space;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public SoftFluent.Json.NET.Space Clone(bool deep)
        {
            SoftFluent.Json.NET.Space space = new SoftFluent.Json.NET.Space();
            this.CopyTo(space, deep);
            return space;
        }
        
        public SoftFluent.Json.NET.Space Clone()
        {
            SoftFluent.Json.NET.Space localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("Id") == true))
            {
                this.Id = ((int)(ConvertUtilities.ChangeType(dict["Id"], typeof(int), -1)));
            }
            if ((dict.Contains("Name") == true))
            {
                this.Name = ((string)(ConvertUtilities.ChangeType(dict["Name"], typeof(string), default(string))));
            }
            if ((dict.Contains("TVA") == true))
            {
                this.TVA = ((float)(ConvertUtilities.ChangeType(dict["TVA"], typeof(float), CodeFluentPersistence.DefaultSingleValue)));
            }
            if ((dict.Contains("Price") == true))
            {
                this.Price = ((decimal)(ConvertUtilities.ChangeType(dict["Price"], typeof(decimal), CodeFluentPersistence.DefaultDecimalValue)));
            }
            if ((dict.Contains("Height") == true))
            {
                this.Height = ((float)(ConvertUtilities.ChangeType(dict["Height"], typeof(float), CodeFluentPersistence.DefaultSingleValue)));
            }
            if ((dict.Contains("Description") == true))
            {
                this.Description = ((string)(ConvertUtilities.ChangeType(dict["Description"], typeof(string), default(string))));
            }
            if ((dict.Contains("Width") == true))
            {
                this.Width = ((float)(ConvertUtilities.ChangeType(dict["Width"], typeof(float), CodeFluentPersistence.DefaultSingleValue)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(SoftFluent.Json.NET.Space space, bool deep)
        {
            if ((space == null))
            {
                throw new System.ArgumentNullException("space");
            }
            space.Id = this.Id;
            space.Name = this.Name;
            space.TVA = this.TVA;
            space.Price = this.Price;
            space.Height = this.Height;
            space.Description = this.Description;
            space.Width = this.Width;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, space));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["Id"] = this.Id;
            dict["Name"] = this.Name;
            dict["TVA"] = this.TVA;
            dict["Price"] = this.Price;
            dict["Height"] = this.Height;
            dict["Description"] = this.Description;
            dict["Width"] = this.Width;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
        
        protected void OnCollectionKeyChanged(string key)
        {
            if ((this.KeyChanged != null))
            {
                this.KeyChanged(this, new CodeFluent.Runtime.Utilities.KeyChangedEventArgs<string>(key));
            }
        }
    }
}