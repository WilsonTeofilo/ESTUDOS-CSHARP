int index = 0;

Console.WriteLine("Selecione uma das opções a seguir");
Console.WriteLine("1-Criar \n2-Editar \n3-Apagar \n4-Logout");

int.TryParse(Console.ReadLine(),out index);
Menus variavel = (Menus)index;



switch (variavel)
{
    case Menus.Criar:
        Console.WriteLine("Criado");
        break;

    case Menus.Editar:
        Console.WriteLine("editado");
        break;


    case Menus.Apagar:
        Console.WriteLine("APAGADO");
        break;

    case Menus.Logout:
        Console.WriteLine("deslogando");
        break;

    default:
        Console.WriteLine("nada aconteceu");
        break;

}


enum Menus { Criar = 1, Editar, Apagar, Logout }