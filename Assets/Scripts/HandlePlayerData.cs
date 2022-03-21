using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayerData : MonoBehaviour
{

    public static HandlePlayerData Instance;

    public string PlayerName;


    private void Awake(){
        if(Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }


}
