using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using System.Linq;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class RacingModeGameManager : MonoBehaviourPunCallbacks
{
    public GameObject[] PlayerPrefabs;
    public GameObject InitialPositionCheckpoint;

    public Text timeUIText;
    public GameObject[] FinishedOrderUIGameObjects;


    public List<GameObject> Checkpoints = new List<GameObject>();

    //public GameObject[] CurrentPlayers;
    public GameObject[] obj;

    public Dictionary<int, string> PosicionCarrera = new Dictionary<int, string>();

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

            StartCoroutine(GenerarItems());
           StartCoroutine(GenerarPosiciones());
        }

        foreach (GameObject gm in FinishedOrderUIGameObjects)
        {
            gm.SetActive(false);
        }

    }

    IEnumerator GenerarItems()
    {
        while (true)
        {
            var CurrentPlayers = GameObject.FindGameObjectsWithTag("Player");
            List<int> checkpoint_jugador = new List<int>();


            foreach (GameObject jugador in CurrentPlayers)
            {
                checkpoint_jugador.Add(jugador.GetComponent<LapController>().NumeroCheckpointActual);
            }


            int Cp_random = Random.Range(checkpoint_jugador.Min() + 1, checkpoint_jugador.Max() );
            int Obj_random_index = Random.Range(0, obj.Length);
            Debug.Log("Objeto: " + Obj_random_index);
            PhotonNetwork.Instantiate(NombreObjetoRandom(Obj_random_index), transform.position = Checkpoints[Cp_random].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }

    public string NombreObjetoRandom(int index)
    {
        return obj[index].name;
    }

    IEnumerator GenerarPosiciones()
    {

        while (true)
        {
            Dictionary<string, float> PosicionX = new Dictionary<string, float>();
            var CurrentPlayers = GameObject.FindGameObjectsWithTag("Player");
            //Adjuntar posicion del jugador con su ID en la sala
            foreach (GameObject jugador in CurrentPlayers)
            {
                PosicionX.Add(jugador.name, jugador.transform.position.x);
            }
            //Ordenar PosicionX descendientemente
            PosicionX = PosicionX.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int cont = 1;
            foreach (KeyValuePair<string, float> Jugadorx in PosicionX)
            {
                if (PosicionCarrera.ContainsKey(cont))
                {
                    PosicionCarrera.Remove(cont);
                }
                PosicionCarrera.Add(cont, Jugadorx.Key);
                Debug.LogFormat("El jugador {0} va en la posición {1}", Jugadorx.Key, cont);
                cont++;
            }
            yield return new WaitForSeconds(0.2f);
        }
        
    }

    public void PresionarBotonSalir()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("LobbyScene");
        Destroy(gameObject);
    }
}
