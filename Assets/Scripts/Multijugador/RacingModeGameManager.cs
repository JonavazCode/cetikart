using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RacingModeGameManager : MonoBehaviour
{
    public GameObject[] PlayerPrefabs;
    public GameObject InitialPositionCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsConnectedAndReady)
        {
            object playerSelectionNumber;
            if (PhotonNetwork.LocalPlayer.CustomProperties.TryGetValue(MultiplayerRacingGame.PLAYER_SELECTION_NUMBER, out playerSelectionNumber))
            {
                Debug.Log((int)playerSelectionNumber);
                Vector3 initialPosition = InitialPositionCheckpoint.transform.position;
                PhotonNetwork.Instantiate(PlayerPrefabs[(int)playerSelectionNumber].name, initialPosition, Quaternion.identity);
            }
        }
        //PhotonNetwork.Instantiate()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
