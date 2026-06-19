using HerancaPoli;

Ave bird = new Ave();
Mamifero mammal = new Mamifero();
Peixe fish = new Peixe();
Reptil reptile = new Reptil();


Console.WriteLine("MAMÍFERO:");
Console.WriteLine($"peso mamifero: {mammal.peso = 85.5f} KG");
Console.WriteLine($"idade: {mammal.idade = 20}");
Console.WriteLine($"membros: {mammal.corPelo = "castanho"}"); 
mammal.locomover();
mammal.alimentar();
mammal.emitirSom();
Console.WriteLine("fim mamifero \n");

Console.WriteLine("AVE:");
Console.WriteLine($"Peso ave: {bird.peso = 8.7f} KG");
Console.WriteLine($"idade: {bird.idade = 8}");
Console.WriteLine($"Membros: {bird.membros = 4}");  
bird.corPena = "branco";
bird.fazerNinho();
bird.alimentar();
bird.emitirSom();
Console.WriteLine("Fim ave");
