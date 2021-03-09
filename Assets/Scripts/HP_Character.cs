using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Character : MonoBehaviour
{
    public string nameCharacter = "";
    public int hp = 5;
    bool rotando;
    
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

    private void Update()
    {
        if(rotando)
        {
            transform.Rotate(transform.forward * 5);
        }
    }

    private void OnMouseEnter()
    {
        rotando = true;
    }
    private void OnMouseExit()
    {
        rotando = false;
    }
}
