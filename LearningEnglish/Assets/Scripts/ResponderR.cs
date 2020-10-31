/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class responderR : MonoBehaviour
{


    public Text infoResposta;
    public Text infoExplicacao;
    public string[] explicacao;      //explicacão da pergunta

    private int idPergunta;
    private int idTema;
    private int intPerguntasTotais;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        idPergunta = PlayerPrefs.GetInt("idPergunta");
        intPerguntasTotais = PlayerPrefs.GetInt("PerguntasTotais" + idTema);
        infoResposta.text = PlayerPrefs.GetString("RespostaCorreta" + idTema + idPergunta);
        infoExplicacao.text = explicacao[idPergunta];
    }

    /// <summary>
    /// O que faz o botão "Próxima Pergunta" na tela "R"
    /// </summary>
    public void proximaPergunta()
    {
        idPergunta++;
        PlayerPrefs.SetInt("idPergunta", idPergunta);

        if (idPergunta < intPerguntasTotais)
        {
            SceneManager.LoadScene("T" + (idTema).ToString());
        }
        else
        {   // o que fazer se terminar as perguntas
            //Zerar a posição das perguntas
            PlayerPrefs.SetInt("idPergunta", 0);
            //Chamar a tela da nota final
            SceneManager.LoadScene("notaFinal");
        }
    }
}
*/