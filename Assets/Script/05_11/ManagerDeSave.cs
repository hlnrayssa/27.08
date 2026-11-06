using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ManagerDeSave : MonoBehaviour
{

    string caminho;
    string nomeArquivo;
    string nomeArquivoJ;
    string extensao;
    string pasta;

    public string separacao = "***";

    string arquivoCompleto;
    string arquivoCompletoJ;
    public Text textoSaida;

    public PlayerBase playerBase;

    // Start is called before the first frame update
    void Start()
    {
        caminho = Application.streamingAssetsPath + "/Helen/";
        pasta = "Save";
        nomeArquivo = "PlayerSave";
        nomeArquivoJ = "PlayerSaveJson";
        extensao = ".txt";


        arquivoCompleto = caminho + "/" + pasta + "/" + nomeArquivo + extensao;
        arquivoCompletoJ = caminho + "/" + pasta + "/" + nomeArquivoJ + extensao;


    }

    public void CreateFolder()
    {
        Directory.CreateDirectory(caminho + "/" + pasta);
    }

public void CreateFile()
    {
       if(File.Exists(arquivoCompleto))
        {
            Debug.Log("Arquivo já existe");
       }
       else
        {
            File.WriteAllText(arquivoCompleto, "Opa-lala\n");
        }
    }

    void EscreverLinhaNova()
    {
        string linha = "\nbatata";
        File.AppendAllText(arquivoCompleto, linha);
    }

    public void LerArquivo()
    {
       string conteudo = File.ReadAllText(arquivoCompleto);
       string[] dadosLidos = conteudo.Split(separacao);
        textoSaida.text = "Nome: " + dadosLidos[0] + "\n" + "Vida: " + dadosLidos[1] + "\n" + "XP: " + dadosLidos[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SalvarPlayer()
    {
        File.WriteAllText(arquivoCompleto, "");
        string conteudo = playerBase.playerData.nome + separacao + playerBase.playerData.vida + separacao + playerBase.playerData.xp;

        File.AppendAllText(arquivoCompleto, conteudo);

    }

    public void SalvarJson()
    {
        playerBase.playerData.posicao = playerBase.transform.position;
        playerBase.playerData.rotacao = playerBase.transform.rotation;
        playerBase.playerData.escala = playerBase.transform.localScale;
        string playerDataJson = JsonUtility.ToJson(playerBase.playerData);
        File.WriteAllText(arquivoCompletoJ, "");
        File.AppendAllText(arquivoCompletoJ, playerDataJson);
    }

    public void LoadJson()
    {
        string conteudoJson = File.ReadAllText(arquivoCompletoJ);
        PlayerData dataLida = JsonUtility.FromJson<PlayerData>(conteudoJson);
        textoSaida.text = "Nome: " + dataLida.nome + "\n" + "Vida: " + dataLida.vida + "\n" + "XP: " + dataLida.xp;

        playerBase.playerData = dataLida;

    }
}
