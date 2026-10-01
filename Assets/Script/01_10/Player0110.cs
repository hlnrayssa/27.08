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


    //para properties é boa prática sempre começar com letra maiuscula e set como private se não for usado
    public int PorcentagemVida
    { get { return vida / vidaMax; } }

    public int AtaqueEspecial
    {
        //pegar as variáveis e faz o cálculo, mas não seta elas definitivamente
        get { return atk * (buff - debuff); }
        private set {}
    }

    public int Vida
    {
        get { return vida * level; }
        set 
        {
            //pode ter loops dentro dos properties
            //vida = value > 0 ? value : 0; if ternario
            /* condição ? valorSeVerdadeiro : valorSeFalso
             * se value for maior que 0
             * verdadeiro = ele continua como value
             * falso = ele vai ser 0
             */

            //indicar que vida é o value que está sendo passado para o property e não a variável vida
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
            { 
                vida = 0;
                level--;
            }
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
            //value é o valor que está sendo passado para a vida, e estamos dizendo que o valor mínimo que ele pode chegar é 0 e o máximo é o vidaMax
            //se o value for < 0 ou ele voltará para 0, se value > vidaMax ele volta para vidaMax

        }
    }*/


    // Update is called once per frame
    void Update()
    {
        Inimigo0110 enemy = new Inimigo0110();
        Debug.Log(enemy.PosX);
    }
}
