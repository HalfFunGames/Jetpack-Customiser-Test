using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThing : MonoBehaviour {

    public static PlayerThing instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }
}
