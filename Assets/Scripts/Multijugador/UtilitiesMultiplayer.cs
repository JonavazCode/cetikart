using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilitiesMultiplayer 
{

    public static int PositionInCareer(this GameObject Player, int position = 0)
    {
        foreach (KeyValuePair<int, string> Jugador in RacingModeGameManager.instance.PosicionCarrera)
        {
            if (Jugador.Value == Player.name)
            {
                return position = Jugador.Key;
            }
        }
        return 0;
    }

}
