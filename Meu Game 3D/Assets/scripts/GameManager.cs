using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

 public TextMeshProUGUI hud, MsgVitoria;
 public int restantes;

    


    void Start()
    {
       restantes = FindObjectsOfType<moeda>().Length;

       hud.text = $"Moedas restantes: {restantes}";
    }


    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
         hud.text = $"Moedas restantes: {restantes}";
         
        if (restantes <= 0)
        {
            MsgVitoria.text = "GANHOU!!!!";
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
