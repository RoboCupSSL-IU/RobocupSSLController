// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grSim_Replacement.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from grSim_Replacement.proto</summary>
public static partial class GrSimReplacementReflection {

  #region Descriptor
  /// <summary>File descriptor for grSim_Replacement.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GrSimReplacementReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdnclNpbV9SZXBsYWNlbWVudC5wcm90byJrChZnclNpbV9Sb2JvdFJlcGxh",
          "Y2VtZW50EgkKAXgYASABKAESCQoBeRgCIAEoARILCgNkaXIYAyABKAESCgoC",
          "aWQYBCABKA0SEgoKeWVsbG93dGVhbRgFIAEoCBIOCgZ0dXJub24YBiABKAgi",
          "RQoVZ3JTaW1fQmFsbFJlcGxhY2VtZW50EgkKAXgYASABKAESCQoBeRgCIAEo",
          "ARIKCgJ2eBgDIAEoARIKCgJ2eRgEIAEoASJiChFnclNpbV9SZXBsYWNlbWVu",
          "dBIkCgRiYWxsGAEgASgLMhYuZ3JTaW1fQmFsbFJlcGxhY2VtZW50EicKBnJv",
          "Ym90cxgCIAMoCzIXLmdyU2ltX1JvYm90UmVwbGFjZW1lbnRiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::grSim_RobotReplacement), global::grSim_RobotReplacement.Parser, new[]{ "X", "Y", "Dir", "Id", "Yellowteam", "Turnon" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::grSim_BallReplacement), global::grSim_BallReplacement.Parser, new[]{ "X", "Y", "Vx", "Vy" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::grSim_Replacement), global::grSim_Replacement.Parser, new[]{ "Ball", "Robots" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class grSim_RobotReplacement : pb::IMessage<grSim_RobotReplacement> {
  private static readonly pb::MessageParser<grSim_RobotReplacement> _parser = new pb::MessageParser<grSim_RobotReplacement>(() => new grSim_RobotReplacement());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<grSim_RobotReplacement> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrSimReplacementReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_RobotReplacement() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_RobotReplacement(grSim_RobotReplacement other) : this() {
    x_ = other.x_;
    y_ = other.y_;
    dir_ = other.dir_;
    id_ = other.id_;
    yellowteam_ = other.yellowteam_;
    turnon_ = other.turnon_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_RobotReplacement Clone() {
    return new grSim_RobotReplacement(this);
  }

  /// <summary>Field number for the "x" field.</summary>
  public const int XFieldNumber = 1;
  private double x_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double X {
    get { return x_; }
    set {
      x_ = value;
    }
  }

  /// <summary>Field number for the "y" field.</summary>
  public const int YFieldNumber = 2;
  private double y_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Y {
    get { return y_; }
    set {
      y_ = value;
    }
  }

  /// <summary>Field number for the "dir" field.</summary>
  public const int DirFieldNumber = 3;
  private double dir_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Dir {
    get { return dir_; }
    set {
      dir_ = value;
    }
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 4;
  private uint id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "yellowteam" field.</summary>
  public const int YellowteamFieldNumber = 5;
  private bool yellowteam_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Yellowteam {
    get { return yellowteam_; }
    set {
      yellowteam_ = value;
    }
  }

  /// <summary>Field number for the "turnon" field.</summary>
  public const int TurnonFieldNumber = 6;
  private bool turnon_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Turnon {
    get { return turnon_; }
    set {
      turnon_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as grSim_RobotReplacement);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(grSim_RobotReplacement other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(X, other.X)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Y, other.Y)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Dir, other.Dir)) return false;
    if (Id != other.Id) return false;
    if (Yellowteam != other.Yellowteam) return false;
    if (Turnon != other.Turnon) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (X != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(X);
    if (Y != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Y);
    if (Dir != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Dir);
    if (Id != 0) hash ^= Id.GetHashCode();
    if (Yellowteam != false) hash ^= Yellowteam.GetHashCode();
    if (Turnon != false) hash ^= Turnon.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (X != 0D) {
      output.WriteRawTag(9);
      output.WriteDouble(X);
    }
    if (Y != 0D) {
      output.WriteRawTag(17);
      output.WriteDouble(Y);
    }
    if (Dir != 0D) {
      output.WriteRawTag(25);
      output.WriteDouble(Dir);
    }
    if (Id != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Id);
    }
    if (Yellowteam != false) {
      output.WriteRawTag(40);
      output.WriteBool(Yellowteam);
    }
    if (Turnon != false) {
      output.WriteRawTag(48);
      output.WriteBool(Turnon);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (X != 0D) {
      size += 1 + 8;
    }
    if (Y != 0D) {
      size += 1 + 8;
    }
    if (Dir != 0D) {
      size += 1 + 8;
    }
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (Yellowteam != false) {
      size += 1 + 1;
    }
    if (Turnon != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(grSim_RobotReplacement other) {
    if (other == null) {
      return;
    }
    if (other.X != 0D) {
      X = other.X;
    }
    if (other.Y != 0D) {
      Y = other.Y;
    }
    if (other.Dir != 0D) {
      Dir = other.Dir;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.Yellowteam != false) {
      Yellowteam = other.Yellowteam;
    }
    if (other.Turnon != false) {
      Turnon = other.Turnon;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 9: {
          X = input.ReadDouble();
          break;
        }
        case 17: {
          Y = input.ReadDouble();
          break;
        }
        case 25: {
          Dir = input.ReadDouble();
          break;
        }
        case 32: {
          Id = input.ReadUInt32();
          break;
        }
        case 40: {
          Yellowteam = input.ReadBool();
          break;
        }
        case 48: {
          Turnon = input.ReadBool();
          break;
        }
      }
    }
  }

}

public sealed partial class grSim_BallReplacement : pb::IMessage<grSim_BallReplacement> {
  private static readonly pb::MessageParser<grSim_BallReplacement> _parser = new pb::MessageParser<grSim_BallReplacement>(() => new grSim_BallReplacement());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<grSim_BallReplacement> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrSimReplacementReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_BallReplacement() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_BallReplacement(grSim_BallReplacement other) : this() {
    x_ = other.x_;
    y_ = other.y_;
    vx_ = other.vx_;
    vy_ = other.vy_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_BallReplacement Clone() {
    return new grSim_BallReplacement(this);
  }

  /// <summary>Field number for the "x" field.</summary>
  public const int XFieldNumber = 1;
  private double x_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double X {
    get { return x_; }
    set {
      x_ = value;
    }
  }

  /// <summary>Field number for the "y" field.</summary>
  public const int YFieldNumber = 2;
  private double y_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Y {
    get { return y_; }
    set {
      y_ = value;
    }
  }

  /// <summary>Field number for the "vx" field.</summary>
  public const int VxFieldNumber = 3;
  private double vx_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Vx {
    get { return vx_; }
    set {
      vx_ = value;
    }
  }

  /// <summary>Field number for the "vy" field.</summary>
  public const int VyFieldNumber = 4;
  private double vy_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Vy {
    get { return vy_; }
    set {
      vy_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as grSim_BallReplacement);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(grSim_BallReplacement other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(X, other.X)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Y, other.Y)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Vx, other.Vx)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Vy, other.Vy)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (X != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(X);
    if (Y != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Y);
    if (Vx != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Vx);
    if (Vy != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Vy);
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (X != 0D) {
      output.WriteRawTag(9);
      output.WriteDouble(X);
    }
    if (Y != 0D) {
      output.WriteRawTag(17);
      output.WriteDouble(Y);
    }
    if (Vx != 0D) {
      output.WriteRawTag(25);
      output.WriteDouble(Vx);
    }
    if (Vy != 0D) {
      output.WriteRawTag(33);
      output.WriteDouble(Vy);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (X != 0D) {
      size += 1 + 8;
    }
    if (Y != 0D) {
      size += 1 + 8;
    }
    if (Vx != 0D) {
      size += 1 + 8;
    }
    if (Vy != 0D) {
      size += 1 + 8;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(grSim_BallReplacement other) {
    if (other == null) {
      return;
    }
    if (other.X != 0D) {
      X = other.X;
    }
    if (other.Y != 0D) {
      Y = other.Y;
    }
    if (other.Vx != 0D) {
      Vx = other.Vx;
    }
    if (other.Vy != 0D) {
      Vy = other.Vy;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 9: {
          X = input.ReadDouble();
          break;
        }
        case 17: {
          Y = input.ReadDouble();
          break;
        }
        case 25: {
          Vx = input.ReadDouble();
          break;
        }
        case 33: {
          Vy = input.ReadDouble();
          break;
        }
      }
    }
  }

}

public sealed partial class grSim_Replacement : pb::IMessage<grSim_Replacement> {
  private static readonly pb::MessageParser<grSim_Replacement> _parser = new pb::MessageParser<grSim_Replacement>(() => new grSim_Replacement());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<grSim_Replacement> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GrSimReplacementReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_Replacement() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_Replacement(grSim_Replacement other) : this() {
    ball_ = other.ball_ != null ? other.ball_.Clone() : null;
    robots_ = other.robots_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public grSim_Replacement Clone() {
    return new grSim_Replacement(this);
  }

  /// <summary>Field number for the "ball" field.</summary>
  public const int BallFieldNumber = 1;
  private global::grSim_BallReplacement ball_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::grSim_BallReplacement Ball {
    get { return ball_; }
    set {
      ball_ = value;
    }
  }

  /// <summary>Field number for the "robots" field.</summary>
  public const int RobotsFieldNumber = 2;
  private static readonly pb::FieldCodec<global::grSim_RobotReplacement> _repeated_robots_codec
      = pb::FieldCodec.ForMessage(18, global::grSim_RobotReplacement.Parser);
  private readonly pbc::RepeatedField<global::grSim_RobotReplacement> robots_ = new pbc::RepeatedField<global::grSim_RobotReplacement>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::grSim_RobotReplacement> Robots {
    get { return robots_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as grSim_Replacement);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(grSim_Replacement other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Ball, other.Ball)) return false;
    if(!robots_.Equals(other.robots_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (ball_ != null) hash ^= Ball.GetHashCode();
    hash ^= robots_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (ball_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Ball);
    }
    robots_.WriteTo(output, _repeated_robots_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (ball_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ball);
    }
    size += robots_.CalculateSize(_repeated_robots_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(grSim_Replacement other) {
    if (other == null) {
      return;
    }
    if (other.ball_ != null) {
      if (ball_ == null) {
        Ball = new global::grSim_BallReplacement();
      }
      Ball.MergeFrom(other.Ball);
    }
    robots_.Add(other.robots_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          if (ball_ == null) {
            Ball = new global::grSim_BallReplacement();
          }
          input.ReadMessage(Ball);
          break;
        }
        case 18: {
          robots_.AddEntriesFrom(input, _repeated_robots_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
