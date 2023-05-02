namespace webAPI.Services;

public class RpgServices
{
    public static IList<Rpg> database;

    static RpgServices()
    {
        database = new List<Rpg>();
        database.Add(item:new Rpg(){ id = 0, name = "BOSS", lv = 999 });
        database.Add(item:new Rpg(){ id = 1, name = "史萊姆", lv = 1 });
        database.Add(item:new Rpg(){ id = 2, name = "殭屍", lv = 5 });
    }

    public Rpg Get(int id)
    {
        Rpg result = null;

        var db = from d in database
            where d.id == id
            select d;

        if (db.Any())
        {
            result = db.First();
        }

        return result;
    }

    public Rpg Create(Rpg rpg)
    {
        rpg.id = database.Max(x => x.id)+1;
        database.Add(rpg);
        return rpg;
    }
}