using System;

public class ArbolAVL
{
    public NodoAVL raiz;

    int ObtenerAltura(NodoAVL nodo)
    {
        if (nodo == null)
            return 0;
        return nodo.altura;
    }

    int ObtenerBalance(NodoAVL nodo)
    {
        if (nodo == null)
            return 0;
        return ObtenerAltura(nodo.izquierda) - ObtenerAltura(nodo.derecha);
    }

    NodoAVL RotacionDerecha(NodoAVL y)
    {
        NodoAVL x = y.izquierda;
        NodoAVL T2 = x.derecha;

        x.derecha = y;
        y.izquierda = T2;

        y.altura = Math.Max(ObtenerAltura(y.izquierda), ObtenerAltura(y.derecha)) + 1;
        x.altura = Math.Max(ObtenerAltura(x.izquierda), ObtenerAltura(x.derecha)) + 1;

        return x;
    }

    NodoAVL RotacionIzquierda(NodoAVL x)
    {
        NodoAVL y = x.derecha;
        NodoAVL T2 = y.izquierda;

        y.izquierda = x;
        x.derecha = T2;

        x.altura = Math.Max(ObtenerAltura(x.izquierda), ObtenerAltura(x.derecha)) + 1;
        y.altura = Math.Max(ObtenerAltura(y.izquierda), ObtenerAltura(y.derecha)) + 1;

        return y;
    }

    public NodoAVL Insertar(NodoAVL nodo, int valor)
    {
        if (nodo == null)
            return new NodoAVL(valor);

        if (valor < nodo.valor)
            nodo.izquierda = Insertar(nodo.izquierda, valor);
        else if (valor > nodo.valor)
            nodo.derecha = Insertar(nodo.derecha, valor);
        else
            return nodo;

        nodo.altura = 1 + Math.Max(ObtenerAltura(nodo.izquierda), ObtenerAltura(nodo.derecha));

        int balance = ObtenerBalance(nodo);

        if (balance > 1 && valor < nodo.izquierda.valor)
            return RotacionDerecha(nodo);

        if (balance < -1 && valor > nodo.derecha.valor)
            return RotacionIzquierda(nodo);

        if (balance > 1 && valor > nodo.izquierda.valor)
        {
            nodo.izquierda = RotacionIzquierda(nodo.izquierda);
            return RotacionDerecha(nodo);
        }

        if (balance < -1 && valor < nodo.derecha.valor)
        {
            nodo.derecha = RotacionDerecha(nodo.derecha);
            return RotacionIzquierda(nodo);
        }

        return nodo;
    }

    public void EnOrden(NodoAVL nodo)
    {
        if (nodo != null)
        {
            EnOrden(nodo.izquierda);
            Console.Write(nodo.valor + " ");
            EnOrden(nodo.derecha);
        }
    }
}