using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public PlayerData playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData.nome = "Helen";
        playerData.vida = 75;
        playerData.xp = 150f;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
