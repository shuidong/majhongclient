//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: proto/game_server.proto
namespace tutorial
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"profile_api")]
  public partial class profile_api : global::ProtoBuf.IExtensible
  {
    public profile_api() {}
    

    private string _SESSIONID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SESSIONID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SESSIONID
    {
      get { return _SESSIONID; }
      set { _SESSIONID = value; }
    }

    private string _client_version = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"client_version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string client_version
    {
      get { return _client_version; }
      set { _client_version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"profile_response")]
  public partial class profile_response : global::ProtoBuf.IExtensible
  {
    public profile_response() {}
    

    private tutorial.status_info _status_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.status_info status_info
    {
      get { return _status_info; }
      set { _status_info = value; }
    }

    private tutorial.user_info _user_info = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.user_info user_info
    {
      get { return _user_info; }
      set { _user_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"app_login__weixin_api")]
  public partial class app_login__weixin_api : global::ProtoBuf.IExtensible
  {
    public app_login__weixin_api() {}
    

    private string _openid = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"openid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string openid
    {
      get { return _openid; }
      set { _openid = value; }
    }

    private string _access_token = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"access_token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string access_token
    {
      get { return _access_token; }
      set { _access_token = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"app_login__weixin_response")]
  public partial class app_login__weixin_response : global::ProtoBuf.IExtensible
  {
    public app_login__weixin_response() {}
    

    private tutorial.status_info _status_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.status_info status_info
    {
      get { return _status_info; }
      set { _status_info = value; }
    }

    private tutorial.user_info _user_info = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.user_info user_info
    {
      get { return _user_info; }
      set { _user_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"logout_api")]
  public partial class logout_api : global::ProtoBuf.IExtensible
  {
    public logout_api() {}
    

    private string _SESSIONID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SESSIONID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SESSIONID
    {
      get { return _SESSIONID; }
      set { _SESSIONID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"logout_response")]
  public partial class logout_response : global::ProtoBuf.IExtensible
  {
    public logout_response() {}
    

    private tutorial.status_info _status_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.status_info status_info
    {
      get { return _status_info; }
      set { _status_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"staticc__FlowR_api")]
  public partial class staticc__FlowR_api : global::ProtoBuf.IExtensible
  {
    public staticc__FlowR_api() {}
    

    private string _SESSIONID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SESSIONID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SESSIONID
    {
      get { return _SESSIONID; }
      set { _SESSIONID = value; }
    }

    private int _room_num = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"room_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int room_num
    {
      get { return _room_num; }
      set { _room_num = value; }
    }

    private int _coin_type = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"coin_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int coin_type
    {
      get { return _coin_type; }
      set { _coin_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"staticc__FlowR_response")]
  public partial class staticc__FlowR_response : global::ProtoBuf.IExtensible
  {
    public staticc__FlowR_response() {}
    

    private tutorial.status_info _status_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.status_info status_info
    {
      get { return _status_info; }
      set { _status_info = value; }
    }

    private tutorial.flow_info _flow_info = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"flow_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.flow_info flow_info
    {
      get { return _flow_info; }
      set { _flow_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"staticc__ChoiceR_api")]
  public partial class staticc__ChoiceR_api : global::ProtoBuf.IExtensible
  {
    public staticc__ChoiceR_api() {}
    

    private int _rtype = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rtype
    {
      get { return _rtype; }
      set { _rtype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"staticc__ChoiceR_response")]
  public partial class staticc__ChoiceR_response : global::ProtoBuf.IExtensible
  {
    public staticc__ChoiceR_response() {}
    

    private tutorial.status_info _status_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.status_info status_info
    {
      get { return _status_info; }
      set { _status_info = value; }
    }
    private readonly global::System.Collections.Generic.List<tutorial.choice_info> _choice_info = new global::System.Collections.Generic.List<tutorial.choice_info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"choice_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<tutorial.choice_info> choice_info
    {
      get { return _choice_info; }
    }
  
    private readonly global::System.Collections.Generic.List<tutorial.additional_price_unit> _price_unit = new global::System.Collections.Generic.List<tutorial.additional_price_unit>();
    [global::ProtoBuf.ProtoMember(7, Name=@"price_unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<tutorial.additional_price_unit> price_unit
    {
      get { return _price_unit; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"staticc__room_opreation_api")]
  public partial class staticc__room_opreation_api : global::ProtoBuf.IExtensible
  {
    public staticc__room_opreation_api() {}
    

    private string _SESSIONID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SESSIONID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SESSIONID
    {
      get { return _SESSIONID; }
      set { _SESSIONID = value; }
    }

    private int _operation = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"operation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int operation
    {
      get { return _operation; }
      set { _operation = value; }
    }

    private int _rtype = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rtype
    {
      get { return _rtype; }
      set { _rtype = value; }
    }

    private int _room_num = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"room_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int room_num
    {
      get { return _room_num; }
      set { _room_num = value; }
    }
    private readonly global::System.Collections.Generic.List<tutorial.play_config_unit> _play_config = new global::System.Collections.Generic.List<tutorial.play_config_unit>();
    [global::ProtoBuf.ProtoMember(5, Name=@"play_config", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<tutorial.play_config_unit> play_config
    {
      get { return _play_config; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"staticc__room_opreation_response")]
  public partial class staticc__room_opreation_response : global::ProtoBuf.IExtensible
  {
    public staticc__room_opreation_response() {}
    

    private tutorial.status_info _status_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.status_info status_info
    {
      get { return _status_info; }
      set { _status_info = value; }
    }

    private tutorial.room_base_info _room_info = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"room_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public tutorial.room_base_info room_info
    {
      get { return _room_info; }
      set { _room_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"play_config_unit")]
  public partial class play_config_unit : global::ProtoBuf.IExtensible
  {
    public play_config_unit() {}
    

    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _choice = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"choice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string choice
    {
      get { return _choice; }
      set { _choice = value; }
    }

    private int _choice_order = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"choice_order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int choice_order
    {
      get { return _choice_order; }
      set { _choice_order = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"room_base_info")]
  public partial class room_base_info : global::ProtoBuf.IExtensible
  {
    public room_base_info() {}
    

    private int _room_num = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"room_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int room_num
    {
      get { return _room_num; }
      set { _room_num = value; }
    }

    private string _tcp_server = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"tcp_server", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tcp_server
    {
      get { return _tcp_server; }
      set { _tcp_server = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"status_info")]
  public partial class status_info : global::ProtoBuf.IExtensible
  {
    public status_info() {}
    

    private string _msg = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }

    private int _code = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int code
    {
      get { return _code; }
      set { _code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"user_info")]
  public partial class user_info : global::ProtoBuf.IExtensible
  {
    public user_info() {}
    

    private string _nickname = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }

    private int _sex = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sex
    {
      get { return _sex; }
      set { _sex = value; }
    }

    private string _photo_url = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"photo_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string photo_url
    {
      get { return _photo_url; }
      set { _photo_url = value; }
    }

    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }

    private int _score = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"score", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int score
    {
      get { return _score; }
      set { _score = value; }
    }

    private int _card = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"card", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int card
    {
      get { return _card; }
      set { _card = value; }
    }

    private int _zuan = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"zuan", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int zuan
    {
      get { return _zuan; }
      set { _zuan = value; }
    }

    private int _gold = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }

    private int _total_score_win = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"total_score_win", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int total_score_win
    {
      get { return _total_score_win; }
      set { _total_score_win = value; }
    }

    private int _total_score_lose = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"total_score_lose", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int total_score_lose
    {
      get { return _total_score_lose; }
      set { _total_score_lose = value; }
    }

    private int _user_point = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"user_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int user_point
    {
      get { return _user_point; }
      set { _user_point = value; }
    }

    private int _user_id = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }

    private string _session_id = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"session_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string session_id
    {
      get { return _session_id; }
      set { _session_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"choice_info")]
  public partial class choice_info : global::ProtoBuf.IExtensible
  {
    public choice_info() {}
    

    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _choice = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"choice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> choice
    {
      get { return _choice; }
    }
  

    private int _default = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"default", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int @default
    {
      get { return _default; }
      set { _default = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"additional_price_unit")]
  public partial class additional_price_unit : global::ProtoBuf.IExtensible
  {
    public additional_price_unit() {}
    

    private string _ju_num = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ju_num", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ju_num
    {
      get { return _ju_num; }
      set { _ju_num = value; }
    }

    private int _price_in_total = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"price_in_total", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int price_in_total
    {
      get { return _price_in_total; }
      set { _price_in_total = value; }
    }

    private int _price_in_aa = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"price_in_aa", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int price_in_aa
    {
      get { return _price_in_aa; }
      set { _price_in_aa = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"flow_info")]
  public partial class flow_info : global::ProtoBuf.IExtensible
  {
    public flow_info() {}
    

    private int _total = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"total", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int total
    {
      get { return _total; }
      set { _total = value; }
    }

    private int _count = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }

    private int _page_num = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"page_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int page_num
    {
      get { return _page_num; }
      set { _page_num = value; }
    }

    private int _page = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int page
    {
      get { return _page; }
      set { _page = value; }
    }
    private readonly global::System.Collections.Generic.List<tutorial.flow_unit> _flow_unit = new global::System.Collections.Generic.List<tutorial.flow_unit>();
    [global::ProtoBuf.ProtoMember(5, Name=@"flow_unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<tutorial.flow_unit> flow_unit
    {
      get { return _flow_unit; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"flow_unit")]
  public partial class flow_unit : global::ProtoBuf.IExtensible
  {
    public flow_unit() {}
    

    private int _before = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"before", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int before
    {
      get { return _before; }
      set { _before = value; }
    }

    private int _amount = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"amount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int amount
    {
      get { return _amount; }
      set { _amount = value; }
    }

    private int _after = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"after", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int after
    {
      get { return _after; }
      set { _after = value; }
    }

    private string _counterparty_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"counterparty_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string counterparty_name
    {
      get { return _counterparty_name; }
      set { _counterparty_name = value; }
    }

    private string _counterparty_photo = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"counterparty_photo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string counterparty_photo
    {
      get { return _counterparty_photo; }
      set { _counterparty_photo = value; }
    }

    private int _counterparty_id = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"counterparty_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int counterparty_id
    {
      get { return _counterparty_id; }
      set { _counterparty_id = value; }
    }

    private int _reason = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int reason
    {
      get { return _reason; }
      set { _reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}