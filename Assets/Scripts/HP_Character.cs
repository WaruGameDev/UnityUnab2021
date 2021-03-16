using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Character : MonoBehaviour
{
    public string nameCharacter = "";
    public int hp = 5;
   
    
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Destroy(gameObject);
            print(nameCharacter + " ha muerto :c");
        }
    }
    private void OnMouseDown()
    {
        TakeDamage(1);
    }
    
}
