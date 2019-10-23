using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCustom : MonoBehaviour
{
    public static PersonajeCustom instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);

        }
        else {
            Destroy(this);

        }
    }
}
