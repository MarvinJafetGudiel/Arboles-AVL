using System;

public class NodoAVL
{
    public int valor;
    public int altura;
    public NodoAVL izquierda;
    public NodoAVL derecha;

    public NodoAVL(int valor)
    {
        this.valor = valor;
        this.altura = 1;
        this.izquierda = null;
        this.derecha = null;
    }
}