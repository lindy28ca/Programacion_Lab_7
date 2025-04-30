using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerController
{
    public void Move();
    public void Attack();
}

public class Player : MonoBehaviour
{
    private IPlayerController controller;
    private TecladoControlador tecladoControlador = new TecladoControlador();
    private GamepadControlador gamepadControlador;
    //private bool state = true;
    [SerializeField] private bool usarTeclado = true;
    void Start()
    {
        controller = tecladoControlador = new TecladoControlador();
    }

    void Update()
    {
        /* if(controller == ?)
         * controller = ?
         * else
         */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            usarTeclado = !usarTeclado;

            if (usarTeclado)
            {
                controller = new TecladoControlador();
            }
            else
            {
                if (gamepadControlador == null)
                    gamepadControlador = new GamepadControlador();
                controller = gamepadControlador;
            }

            Debug.Log("Controlador cambiado a: " + controller.GetType().Name);
        }

        controller = controller == gamepadControlador ? tecladoControlador : gamepadControlador;

        if (Input.GetKeyDown(KeyCode.A))
        {
            controller?.Move();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            controller?.Attack();
        }
    }
}

