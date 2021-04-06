using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager staticGameManager;

    public int puntaje;

    public TextMeshProUGUI puntajeText;
    public TextMeshProUGUI hp_Personaje;
    public HP_Character hpPlayer;


    private void Awake()
    {
        staticGameManager = this;
    }   

    // Update is called once per frame
    void Update()
    {
        puntajeText.text = "Puntaje: " + puntaje;
        hp_Personaje.text = "HP: " + hpPlayer.hp;
    }
}
