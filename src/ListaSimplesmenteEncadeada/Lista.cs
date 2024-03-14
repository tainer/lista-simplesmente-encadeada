namespace ListaSimplesmenteEncadeada;

public class Lista
{
    private Nodo _primeiroNodo;

    public void Adicionar(int valor)
    {
        Nodo novoNodo = new Nodo(valor);

        if (_primeiroNodo == null)
        {
            _primeiroNodo = novoNodo;
            return;
        }

        Nodo ultimoNodo = _primeiroNodo;

        while (ultimoNodo.ProximoNodo != null)
        {
            ultimoNodo = ultimoNodo.ProximoNodo;
        }

        ultimoNodo.ProximoNodo = novoNodo;
    }

    public void Mostrar()
    {
        if (_primeiroNodo == null)
        {
            Console.WriteLine("A lista está vazia!");
            return;
        }

        Console.Write(_primeiroNodo.Valor);

        Nodo nodo = _primeiroNodo.ProximoNodo;
        while (nodo != null)
        {
            Console.Write($", {nodo.Valor}");
            nodo = nodo.ProximoNodo;
        }
        Console.WriteLine();
    }

    public bool Remover(int valor)
    {
        if (_primeiroNodo == null)
        {
            Console.WriteLine("A lista está vazia!");
            return false;
        }

        Nodo nodoARemover;
        if (_primeiroNodo.Valor == valor)
        {
            nodoARemover = _primeiroNodo;

            _primeiroNodo = nodoARemover.ProximoNodo;

            nodoARemover.ProximoNodo = null;

            return true;
        }

        Nodo nodo = _primeiroNodo;
        
        while (nodo.ProximoNodo != null) 
        {
            if (nodo.ProximoNodo.Valor == valor)
            {
                nodoARemover = nodo.ProximoNodo;
                nodo.ProximoNodo = nodoARemover.ProximoNodo;
                nodoARemover.ProximoNodo = null;
                return true;
            }
            nodo = nodo.ProximoNodo;
        }
        return false;
    }
}