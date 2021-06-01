using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPartOfBody : MonoBehaviour
{
    public PART_OF_BODY partPfBody;
    public int id;

    public void OnSelectPartOfBody()
    {
        CharacterManager.instance.SelectParteDelCuerpo(id, partPfBody);
    }
}
