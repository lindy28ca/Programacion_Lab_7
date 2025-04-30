using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TecladoControlador : IPlayerController
{
    public void Move()
    {
        Debug.Log("Moviendo con teclado");
    }

    public void Attack()
    {
        Debug.Log("Atacando con teclado");
    }
}
