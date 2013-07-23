using FluentCassandra.Thrift.Protocol;
/**
 * Autogenerated by Thrift Compiler (0.9.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Text;

namespace FluentCassandra.Apache.Cassandra
{

  /// <summary>
  /// The ColumnPath is the path to a single column in Cassandra. It might make sense to think of ColumnPath and
  /// ColumnParent in terms of a directory structure.
  /// 
  /// ColumnPath is used to looking up a single column.
  /// 
  /// @param column_family. The name of the CF of the column being looked up.
  /// @param super_column. The super column name.
  /// @param column. The column name.
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ColumnPath : TBase
  {
    private string _column_family;
    private byte[] _super_column;
    private byte[] _column;

    public string Column_family
    {
      get
      {
        return _column_family;
      }
      set
      {
        __isset.column_family = true;
        this._column_family = value;
      }
    }

    public byte[] Super_column
    {
      get
      {
        return _super_column;
      }
      set
      {
        __isset.super_column = true;
        this._super_column = value;
      }
    }

    public byte[] Column
    {
      get
      {
        return _column;
      }
      set
      {
        __isset.column = true;
        this._column = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool column_family;
      public bool super_column;
      public bool column;
    }

    public ColumnPath() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 3:
            if (field.Type == TType.String) {
              Column_family = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Super_column = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Column = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ColumnPath");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Column_family != null && __isset.column_family) {
        field.Name = "column_family";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Column_family);
        oprot.WriteFieldEnd();
      }
      if (Super_column != null && __isset.super_column) {
        field.Name = "super_column";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Super_column);
        oprot.WriteFieldEnd();
      }
      if (Column != null && __isset.column) {
        field.Name = "column";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Column);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ColumnPath(");
      sb.Append("Column_family: ");
      sb.Append(Column_family);
      sb.Append(",Super_column: ");
      sb.Append(Super_column);
      sb.Append(",Column: ");
      sb.Append(Column);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
