using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    public GameObject field;

    private void OnMouseUpAsButton()
    {
        field.GetComponent<WallBuilder>().NewGame();
    }
}
