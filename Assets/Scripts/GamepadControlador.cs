using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadControlador : IPlayerController
{
    public void Move() 
    {
        Debug.Log("Movimiento con Gamepad");
    }

    public void Attack()
    {
        Debug.Log("Ataque con Gamepad");
    }
}
