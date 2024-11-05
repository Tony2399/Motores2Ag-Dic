using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform startPoint;  // El punto de inicio
    public Transform endPoint;    // El punto final
    public float delay = 1f;      // Tiempo de espera antes de moverse
    public float duration = 2f;   // Duración del movimiento en segundos

    private void Start()
    {
        StartCoroutine(MoveAfterDelay());
    }

    private IEnumerator MoveAfterDelay()
    {
        // Espera el tiempo definido antes de comenzar el movimiento
        yield return new WaitForSeconds(delay);

        float elapsedTime = 0f;

        // Comienza a mover el objeto después de la pausa
        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startPoint.position, endPoint.position, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;  // Espera un frame
        }

        // Asegura que el objeto llegue exactamente al endPoint
        transform.position = endPoint.position;
    }
}
