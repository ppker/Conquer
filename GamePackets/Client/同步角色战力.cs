namespace GamePackets.Client;

[PacketInfo(Source = PacketSource.Client, ID = 21, Length = 6, Description = "同步角色战力")]
public sealed class 同步角色战力 : GamePacket
{
    [FieldAttribute(Position = 2, Length = 4)]
    public int 对象编号;
}
