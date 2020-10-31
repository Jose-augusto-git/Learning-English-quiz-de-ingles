﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class responder : MonoBehaviour
{

    public int idTema;

    public Text pergunta;
    public Image pergunta1;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text respostaE;
    public Text InfoRespostas;

    public string[] perguntas; // armazena as perguntas 
    public Sprite[] perguntas1;
    public string[] alternativaA; // armazena as respostas 
    public string[] alternativaB;//  ||        ||  ||
    public string[] alternativaC;//
    public string[] alternativaD; //
    public string[] alternativaE; //
    public string[] corretas; // armazena as alternativas corretas


    /*


        public Image pergunta;

     public Sprite[] perguntas;

       pergunta.sprite = perguntas[idPergunta];

    */

    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;
    private int notaFinal;

    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        idPergunta = 0;

        questoes = perguntas.Length;
      //  pergunta = perguntas[idPergunta];
        pergunta.text = perguntas[idPergunta];
        pergunta1.sprite = perguntas1[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];
        respostaE.text = alternativaE[idPergunta];

        InfoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas.";


    }

    public void resposta(string alternativa)
    {
        if (alternativa == "A")
        {
            if(alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                

            }
           
            
        }
        else if (alternativa == "B")
        {
            if (alternativaB[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;

            }
        }
        else if (alternativa == "C")
        {
            if (alternativaC[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;

            }
        }



        else if (alternativa == "D")
        {
            if (alternativaD[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;

            }
        }

        else if (alternativa == "E")
        {
            if (alternativaE[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;

            }
        }

        proximaPergunta();

    }

    void proximaPergunta()
    {
        idPergunta += 1;

        if(idPergunta <= (questoes - 1)) { 

        pergunta.text = perguntas[idPergunta];
        pergunta1.sprite = perguntas1[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];
        respostaE.text = alternativaE[idPergunta];

            InfoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + "perguntas.";

        }

        else
        {


            media = 10 * (acertos / questoes);
            notaFinal = Mathf.RoundToInt(media);

            if(notaFinal > PlayerPrefs.GetInt("notaFinal" +idTema.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal" + idTema.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idTema.ToString(),(int) acertos);

            }

            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idTema.ToString(), (int)acertos);

            Application.LoadLevel("notaFinal");
        }

    }



}


