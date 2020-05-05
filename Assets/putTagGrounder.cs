using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putTagGrounder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Conteo de hijos {0}", gameObject.transform.childCount);

        for (int i = 0; i <= gameObject.transform.childCount-1; i++)
        {
            gameObject.transform.GetChild(i).gameObject.tag = "grounder";
            //gameObject.AddComponent<PlatformEffector2D>();
        }
    }

}
