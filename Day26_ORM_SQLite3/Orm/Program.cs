App<Worker> app = new App<Worker>(new ListRepository());

app.Create(new("Василий Иванов", 22, 3312));
app.Create(new("Василий Петров", 44, 4562));
app.Create(new("Иван Васильев", 33, 1245));

app.Print(); Console.WriteLine();

app.Remove(2);
app.Print(); Console.WriteLine();

app.Update(1, new("Sergey Kam", 122, 31312));
app.Print(); Console.WriteLine();
