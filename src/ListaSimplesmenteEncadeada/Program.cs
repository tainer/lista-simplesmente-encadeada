// See https://aka.ms/new-console-template for more information
using ListaSimplesmenteEncadeada;

Console.WriteLine("Hello, World!");

Lista lista = new Lista();
lista.Adicionar(2);
lista.Adicionar(7);
lista.Adicionar(3);
lista.Adicionar(8);
lista.Adicionar(4);
lista.Adicionar(1);
lista.Adicionar(5);
lista.Adicionar(6);
lista.Adicionar(9);

lista.Mostrar();

bool itemRemovido = lista.Remover(98);

if (itemRemovido)
{
    Console.WriteLine("Item removido");
}
else
{
    Console.WriteLine("Item não encontrado!");
}

lista.Mostrar();