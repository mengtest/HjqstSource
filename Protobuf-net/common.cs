//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: common.proto
namespace common
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IntProto")]
  public partial class IntProto : global::ProtoBuf.IExtensible
  {
    public IntProto() {}
    

    private int _value = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DoubleIntProto")]
  public partial class DoubleIntProto : global::ProtoBuf.IExtensible
  {
    public DoubleIntProto() {}
    

    private int _value1 = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value1
    {
      get { return _value1; }
      set { _value1 = value; }
    }

    private int _value2 = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value2
    {
      get { return _value2; }
      set { _value2 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TripleIntProto")]
  public partial class TripleIntProto : global::ProtoBuf.IExtensible
  {
    public TripleIntProto() {}
    

    private int _value1 = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value1
    {
      get { return _value1; }
      set { _value1 = value; }
    }

    private int _value2 = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value2
    {
      get { return _value2; }
      set { _value2 = value; }
    }

    private int _value3 = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"value3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int value3
    {
      get { return _value3; }
      set { _value3 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StringProto")]
  public partial class StringProto : global::ProtoBuf.IExtensible
  {
    public StringProto() {}
    

    private string _value = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}