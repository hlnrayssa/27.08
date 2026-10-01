using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player0110 : MonoBehaviour
{
    int vida;
    int vidaMax = 1000;

    int buff;
    int debuff;
    int level;
    int atk;

    int escudo = 2;

    public int PorcentagemVida
    { get { return vida / vidaMax; } }

    public int AtaqueEspecial
    {
        get { return atk * (buff - debuff); }
        private set {}
    }

    public int Vida
    {
        get { return vida * level; }
        set 
        {
            //vida = value > 0 ? value : 0; if ternario
            vida = value;

            if (vida > 74)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else if (vida > 49)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (vida > 24)
            {
                GetComponent<Renderer>().material.color = Color.gray;
            }
            else if (vida > 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                vida = 0;
                level--;
            }

            

            if (vida <= 0)
            { vida = 0; }
        }
           
    }


    void Start()
    {
        vida = 10;
    }


    /*public int Vida
    {
        get
        {
            return vida;
        }
        set 
        { 
            vida = Mathf.Clamp(value, 0, vidaMax); 
        }
    }*/


    // Update is called once per frame
    void Update()
    {
        Inimigo0110 enemy = new Inimigo0110();
        Debug.Log(enemy.PosX);
    }
}
