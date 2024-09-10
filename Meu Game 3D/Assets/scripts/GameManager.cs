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
       restantes = FindObjectsOfType<moeda>.Lenght;

       hud.text = $"Moedas restantes: {restantes}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
