using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaCripto : MonoBehaviour
{
    [SerializeField]
    InputField textoEntrada;

    [SerializeField]
    InputField textoCripto;

    [SerializeField]
    InputField textoDescripto;

    public void Criptografar()
    {
        Debug.Log("Criptografando");
        string conteudoCripto = "Texto criptografado";

        conteudoCripto = CriptoLib.CriptografarComDuasChaves(textoEntrada.text);

        //CriptoLib.CriptografarComDuasChaves();

        textoCripto.text = conteudoCripto;

    }

    public void Descriptografar()
    {
        Debug.Log("Descriptografando");
        string conteudoDescripto = "Texto descriptografado";

        textoDescripto.text = conteudoDescripto;
    }
}
