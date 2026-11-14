using _17;

Repository<int> intRepo = new Repository<int>([2,5,3,56,6]);
intRepo.Add(5);
intRepo.Remove(56);
Console.WriteLine(intRepo.GetAll());