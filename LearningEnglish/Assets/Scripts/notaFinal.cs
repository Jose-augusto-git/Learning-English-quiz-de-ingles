using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class notaFinal : MonoBehaviour
{

    private int idTema;

    public Text txtNota;
    public Text txtInfoTema;



    private int notaF;
    private int acertos;

    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");



        notaF = PlayerPrefs.GetInt("notalFinalTemp" + idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idTema.ToString());

       // txtNota.text = notaF.ToString();
        txtInfoTema.text = "Você acertou " + acertos.ToString();



    }
}
