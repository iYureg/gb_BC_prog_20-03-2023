public static class Repository
{
    static List<Worker> db;
    static Repository()
    {
        db = new();


        Worker w = new()
        {
            Id = 0,
            Age = 22,
            Salary = 1111,
            FirstName = "Вася",
            LastName = "Васечкин"
        };
        //Create
        Repository.Create(w);
        Repository.Create(new() { Id = 1, Age = 25, Salary = 2222, FirstName = "Маша", LastName = "Васечкина" });
        Repository.Create(new() { Id = 2, Age = 29, Salary = 4444, FirstName = "Юля", LastName = "Иванова" });
        Repository.Create(new() { Id = 3, Age = 19, Salary = 5555, FirstName = "Петя", LastName = "Сергеев" });
        Repository.Create(new() { Id = 4, Age = 44, Salary = 3333, FirstName = "Кто-то", LastName = "???" });

        Worker w1 = Repository.Read(1);
        string json = new WorkerConverter().ToJson(w1);

    }
    public static void Create(Worker w) => db.Add(w);
    public static Worker Read(int id) => db[id];
    public static Worker[] Read() => db.ToArray();
    public static bool Update(int id, Worker w) { db[id] = w; return true; }
    public static void Delete(int id) => db.RemoveAt(id);
}