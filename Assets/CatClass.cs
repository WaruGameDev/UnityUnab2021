using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatClass : MonoBehaviour
{
    // 0 gato normal, 1 gato samurai, 2 gato vaquero
    public SpriteRenderer theSprite;
    public List<Sprite> classes;
    public enum CAT_CLASE
    {
        NORMAL,
        SAMURAI,
        VAQUERO,
        IDOL

    }
    public CAT_CLASE catClase;

    public void ChangeClass(CAT_CLASE nuevaClase)
    {
        catClase = nuevaClase;        
        theSprite.sprite = classes[(int)catClase];        
        //switch(nuevaClase)
        //{
        //    case CAT_CLASE.NORMAL:
        //        theSprite.sprite = classes[0];
        //        break;
        //    case CAT_CLASE.SAMURAI:
        //        theSprite.sprite = classes[1];
        //        break;
        //    case CAT_CLASE.VAQUERO:
        //        theSprite.sprite = classes[2];
        //        break;
        //}
    }
    
}
