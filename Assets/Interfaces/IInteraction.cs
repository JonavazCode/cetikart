using UnityEngine;
using System.Collections;

public interface IInteraction
{
    void moverPj(Vector3 pos);

    void CambiarInmune(bool estado);

    void AumentarCargas();
}