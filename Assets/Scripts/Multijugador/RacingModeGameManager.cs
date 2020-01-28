using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class RacingModeGameManager : MonoBehaviour
{
    public GameObject[] PlayerPrefabs;
    public GameObject InitialPositionCheckpoint;

    public Text timeUIText;
    public GameObject[] FinishedOrderUIGameObjects;


    public List<GameObject> Checkpoints = new List<GameObject>();

    //Implementando un Singleton
    public static RacingModeGameManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

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

        foreach (GameObject gm in FinishedOrderUIGameObjects)
        {
            gm.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
