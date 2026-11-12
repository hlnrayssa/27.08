using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriptoLib : MonoBehaviour
{
    static string chave1 = "vela";
    static string chave2 = "azul";

    public static string CriptografarComDuasChaves(string conteudoOriginal)
    {
        string textoCripto = "";
        char [] caracteres = conteudoOriginal.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLib.BuscarCorrespondencia(caracteres[i]);
        }

        textoCripto = new string(caracteres);

        return textoCripto;
    }

    public static string DescriptografarComDuasChaves(string conteudoCriptografado)
    {
        string textoDescripto = "";

        return textoDescripto;
    }

    static char BuscarCorrespondencia(char charOriginal)
    {
        for (int i = 0; i < chave1.Length; i++)
        {
            if (charOriginal == chave1[i])
            {
               return chave2[i];
            }

            if (charOriginal == chave2[i])
            {
                return chave1[i];
            }

        }

        return charOriginal;
    }
}
