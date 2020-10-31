using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class temaJogo : MonoBehaviour{


    public Button btnPlay;
    public Text txtNomeTema;

    public GameObject infoTema;
    public Text txtInfoTema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public string[] nomeTema;
    public int numeroQuestoes;

    private int idTema;



    // Start is called before the first frame update
    void Start(){
        idTema = 0;
        txtNomeTema.text = nomeTema[idTema];
        txtInfoTema.text = "Você Acertou X de X questões!!";
        infoTema.SetActive(false);
        //estrela1.SetActive(false);
       // estrela2.SetActive(false);
       // estrela3.SetActive(false);
        btnPlay.interactable = false;


    }

    public void selecioneTema(int i)
    {
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNomeTema.text = nomeTema[idTema];

       // int notaFinal ;
        int acertos = 0;

        txtInfoTema.text = "Você Acertou " +acertos.ToString()+ " de " +numeroQuestoes.ToString()+ " questões!!";
        infoTema.SetActive(true);
        btnPlay.interactable = true;

    }

       public void jogar(){

           Application.LoadLevel("T"+idTema.ToString());

    } 
}
