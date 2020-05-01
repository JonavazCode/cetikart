using UnityEngine;
using System.Collections;

public interface IInteraction
{
    void moverPj(Vector3 pos);

    void ActualizarVelocidad(int velocidad);

    void CambiarInmune();

    void AumentarCargas();
}