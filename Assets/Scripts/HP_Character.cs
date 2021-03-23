using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Character : MonoBehaviour
{
    public string nameCharacter = "";
    public int hp = 5;
    public int puntajeADar = 10;
    public bool enemy;
    public bool indestructible;
    
    
    public void TakeDamage(int damage)
    {
        if(!indestructible)
        {
            hp -= damage;
        }
       
        if(hp <= 0)
        {
            if(enemy)
            {
                GameManager.staticGameManager.puntaje += puntajeADar;
                DoorManager.staticDoorManager.enemigosDerrotados++;
            }
            Destroy(gameObject);
            print(nameCharacter + " ha muerto :c");

        }
       
       
    }
    private void OnMouseDown()
    {
        TakeDamage(1);
    }
    
}
