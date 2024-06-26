using System.Collections.Generic;
using System.IO;

namespace GameServer.Template;

public sealed class RandomStats
{
    public static Dictionary<int, RandomStats> DataSheet = new Dictionary<int, RandomStats>();

    public Stat Stat;
    public int Value;
    public int StatID;
    public int CombatBonus;
    public string StatDescription;

    public static void LoadData()
    {
        DataSheet.Clear();

        var path = Settings.Default.GameDataPath + "\\System\\Items\\RandomStats\\";
        if (!Directory.Exists(path))
            return;

        var array = Serializer.Deserialize<RandomStats>(path);
        foreach (var obj in array)
            DataSheet.Add(obj.StatID, obj);
    }
}
