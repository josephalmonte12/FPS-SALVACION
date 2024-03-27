using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkEnemy : MonoBehaviour
{
    public Transform[] waypoints; // Array para almacenar los waypoints
    public float velocidad = 5f; // Velocidad de movimiento del objeto
    private int waypointActual = 0; // Índice del waypoint al que se dirige actualmente el objeto

    void Update()
    {
        // Si no hay waypoints, no hacemos nada
        if (waypoints.Length == 0)
            return;

        // Movimiento hacia el waypoint actual
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointActual].position, velocidad * Time.deltaTime);

        // Si el objeto llega al waypoint actual, pasamos al siguiente
        if (Vector3.Distance(transform.position, waypoints[waypointActual].position) < 0.1f)
        {
            waypointActual = (waypointActual + 1) % waypoints.Length; // Avanzamos al siguiente waypoint

            // Si hemos llegado al último waypoint, regresamos al primero
            if (waypointActual == 0)
            {
                // Aquí puedes agregar lógica adicional si deseas hacer algo especial al llegar al primer waypoint nuevamente
            }
        }
    }
}
