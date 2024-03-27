using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPersecutor : MonoBehaviour
{
    public Transform objetivo; // Objeto a perseguir
    public float velocidad = 5f; // Velocidad de persecuci�n

    void Update()
    {
        if (objetivo == null)
        {
            // Si el objetivo es nulo, no hacemos nada
            return;
        }

        // Calculamos la direcci�n hacia el objetivo
        Vector3 direccion = objetivo.position - transform.position;
        direccion.Normalize(); // Normalizamos la direcci�n para mantener una velocidad constante

        // Calculamos el desplazamiento en este fotograma
        Vector3 desplazamiento = direccion * velocidad * Time.deltaTime;

        // Movemos el objeto perseguidor
        transform.position += desplazamiento;
    }
}
