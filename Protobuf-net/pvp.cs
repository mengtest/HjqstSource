//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: pvp.proto
// Note: requires additional types generated from: team.proto
namespace pvp
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetPvpInfoReq")]
  public partial class GetPvpInfoReq : global::ProtoBuf.IExtensible
  {
    public GetPvpInfoReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetPvpInfoResp")]
  public partial class GetPvpInfoResp : global::ProtoBuf.IExtensible
  {
    public GetPvpInfoResp() {}
    
    private int _point;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int point
    {
      get { return _point; }
      set { _point = value; }
    }
    private int _winTimes;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"winTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int winTimes
    {
      get { return _winTimes; }
      set { _winTimes = value; }
    }
    private int _loseTimes;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"loseTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int loseTimes
    {
      get { return _loseTimes; }
      set { _loseTimes = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _rec = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"rec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> rec
    {
      get { return _rec; }
    }
  
    private int _useTimes;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"useTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int useTimes
    {
      get { return _useTimes; }
      set { _useTimes = value; }
    }
    private bool _isOpen;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"isOpen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isOpen
    {
      get { return _isOpen; }
      set { _isOpen = value; }
    }
    private long _time;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PointPvpChallengeResp")]
  public partial class PointPvpChallengeResp : global::ProtoBuf.IExtensible
  {
    public PointPvpChallengeResp() {}
    
    private team.TeamFightProtoData _selfTeamData;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"selfTeamData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.TeamFightProtoData selfTeamData
    {
      get { return _selfTeamData; }
      set { _selfTeamData = value; }
    }
    private team.TeamFightProtoData _opponentTeamData;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"opponentTeamData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.TeamFightProtoData opponentTeamData
    {
      get { return _opponentTeamData; }
      set { _opponentTeamData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PointPvpSettleReq")]
  public partial class PointPvpSettleReq : global::ProtoBuf.IExtensible
  {
    public PointPvpSettleReq() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PointPvpSettleResp")]
  public partial class PointPvpSettleResp : global::ProtoBuf.IExtensible
  {
    public PointPvpSettleResp() {}
    
    private int _point;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int point
    {
      get { return _point; }
      set { _point = value; }
    }
    private int _keepWinTimes;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"keepWinTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int keepWinTimes
    {
      get { return _keepWinTimes; }
      set { _keepWinTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}