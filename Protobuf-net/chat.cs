//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: chat.proto
namespace chat
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatInfoReq")]
  public partial class ChatInfoReq : global::ProtoBuf.IExtensible
  {
    public ChatInfoReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatProtoData")]
  public partial class ChatProtoData : global::ProtoBuf.IExtensible
  {
    public ChatProtoData() {}
    
    private int _chatType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"chatType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int chatType
    {
      get { return _chatType; }
      set { _chatType = value; }
    }

    private string _sendRoleName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sendRoleName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sendRoleName
    {
      get { return _sendRoleName; }
      set { _sendRoleName = value; }
    }

    private string _revRoleName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"revRoleName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string revRoleName
    {
      get { return _revRoleName; }
      set { _revRoleName = value; }
    }

    private string _content = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }

    private int _noticeNo = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"noticeNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int noticeNo
    {
      get { return _noticeNo; }
      set { _noticeNo = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _noticParams = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(6, Name=@"noticParams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> noticParams
    {
      get { return _noticParams; }
    }
  

    private long _sendTime = default(long);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"sendTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long sendTime
    {
      get { return _sendTime; }
      set { _sendTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatInfoResp")]
  public partial class ChatInfoResp : global::ProtoBuf.IExtensible
  {
    public ChatInfoResp() {}
    
    private readonly global::System.Collections.Generic.List<chat.ChatProtoData> _chatList = new global::System.Collections.Generic.List<chat.ChatProtoData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"chatList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<chat.ChatProtoData> chatList
    {
      get { return _chatList; }
    }
  

    private bool _hasGuild = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hasGuild", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool hasGuild
    {
      get { return _hasGuild; }
      set { _hasGuild = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatReq")]
  public partial class ChatReq : global::ProtoBuf.IExtensible
  {
    public ChatReq() {}
    
    private int _chatType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"chatType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int chatType
    {
      get { return _chatType; }
      set { _chatType = value; }
    }

    private string _revRoleName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"revRoleName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string revRoleName
    {
      get { return _revRoleName; }
      set { _revRoleName = value; }
    }

    private string _content = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatResp")]
  public partial class ChatResp : global::ProtoBuf.IExtensible
  {
    public ChatResp() {}
    
    private int _chatType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"chatType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int chatType
    {
      get { return _chatType; }
      set { _chatType = value; }
    }

    private string _sendRoleName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sendRoleName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sendRoleName
    {
      get { return _sendRoleName; }
      set { _sendRoleName = value; }
    }

    private string _revRoleName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"revRoleName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string revRoleName
    {
      get { return _revRoleName; }
      set { _revRoleName = value; }
    }

    private string _content = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }

    private int _noticeNo = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"noticeNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int noticeNo
    {
      get { return _noticeNo; }
      set { _noticeNo = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _noticParams = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(6, Name=@"noticParams", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> noticParams
    {
      get { return _noticParams; }
    }
  

    private long _sendTime = default(long);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"sendTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long sendTime
    {
      get { return _sendTime; }
      set { _sendTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CheckRoleGuildResp")]
  public partial class CheckRoleGuildResp : global::ProtoBuf.IExtensible
  {
    public CheckRoleGuildResp() {}
    
    private bool _isInGuild;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"isInGuild", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isInGuild
    {
      get { return _isInGuild; }
      set { _isInGuild = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}