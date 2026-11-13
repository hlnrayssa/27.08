using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriptoLib : MonoBehaviour
{
    #region Duas Chaves
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
        char[] caracteres = conteudoCriptografado.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLib.BuscarCorrespondencia(caracteres[i]);
        }

        textoDescripto = new string(caracteres);

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
    #endregion

    #region Deslocamento
    static int valorDeslocamento = 10;

    public static string CriptografiaComDeslocamento(string conteudoOriginal)
    {
        string textoCriptografado = "";
        char[] caracteres = conteudoOriginal.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLib.Deslocar(caracteres[i], true);
        }
        textoCriptografado = new string(caracteres);

        return textoCriptografado;
    }

    public static string DescriptografiaComDeslocamento(string conteudoCriptografado)
    {
        string textoDescriptografado = "";
        char[] caracteres = conteudoCriptografado.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = CriptoLib.Deslocar(caracteres[i], false);

        }

        textoDescriptografado = new string(caracteres);

        return textoDescriptografado;
    }

    public static char Deslocar(char charOriginal, bool criptografando)
    {
        int charInteiro = (charOriginal);
        if (criptografando == true)
        {
            charInteiro = charInteiro + valorDeslocamento;
        }
        else
        {
            charInteiro = charInteiro - valorDeslocamento;
        }

        char charDeslocado = (char)charInteiro;
        return charDeslocado;

    }

    #endregion
}
