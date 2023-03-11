using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSheep : MonoBehaviour
{

    public GameObject Sheep;

    public void SheepStart()
    {
        Instantiate(Sheep); 

    }


}
