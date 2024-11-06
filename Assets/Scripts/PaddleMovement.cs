using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField, Range(1f, 10f), Tooltip("Velocidad de los receptores.")]
    private float velocidad = 5f;
    private float limiteVertical = 3.25f;

    [SerializeField]
    private bool jugador1;

    void Update()
    {
        float movimiento;
        if (jugador1)
        {
            movimiento = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movimiento = Input.GetAxisRaw("Vertical2");
        }

        Vector2 posicionJugador = transform.position;
        posicionJugador.y = Mathf.Clamp(posicionJugador.y + movimiento * velocidad * Time.deltaTime, -limiteVertical, limiteVertical);
        transform.position = posicionJugador;
    }
}
