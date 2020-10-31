using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandosBasicos : MonoBehaviour
{
    public void carregarCena( string nomeCena)
    {
        Application.LoadLevel(nomeCena);

    }
}
