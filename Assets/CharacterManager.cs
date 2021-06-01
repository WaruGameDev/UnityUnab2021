using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PART_OF_BODY
{
    HEAD,
    BODY,
    LEGS
}


public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;
    //cabezas
    public List<Sprite> cabezas;
    public Image cabeza;

    //torso
    public List<Sprite> torsos;
    public Image torso;
    //piernas
    //torso
    public List<Sprite> piernas;
    public Image pierna;
    private void Awake()
    {
        instance = this;
    }
    public void SelectParteDelCuerpo(int i, PART_OF_BODY partOfBody)
    {
        switch(partOfBody)
        {
            case PART_OF_BODY.HEAD:
                cabeza.sprite = cabezas[i];
                break;
            case PART_OF_BODY.BODY:
                torso.sprite = torsos[i];
                break;
            case PART_OF_BODY.LEGS:
                pierna.sprite = piernas[i];
                break;
        }
        
    }
}
