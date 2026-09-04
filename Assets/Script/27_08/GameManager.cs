using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Player player;

    void Start()
    {
        Vector3 teste = new Vector3(5, 10, -1);
        Info dadosPlayer = new Info("Jorge", "Cavaleiro", "Orc");

    }

    private void Update()
    {
        
    }
}
