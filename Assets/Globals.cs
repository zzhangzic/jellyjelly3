using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour {
    public static int play1_defeat = 0;
    public static int play2_defeat = 0;
    public static int coin_collected;
    private static Globals _instance;
    public static Globals instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("Gloabal_Variable").AddComponent<Globals>();
            }
            return _instance;
        }
    }
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        coin_collected = 0;
    }
}
