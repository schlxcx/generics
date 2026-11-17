using _17;

Repository<int> intRepo = new Repository<int>([2,5,3,56,6]);
intRepo.Add(5);
intRepo.Remove(56);
foreach (var item in intRepo.GetAll())
{
    Console.WriteLine(item);
}

