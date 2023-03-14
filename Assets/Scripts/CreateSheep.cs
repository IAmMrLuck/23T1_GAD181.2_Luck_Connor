using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ConaLuk
{

    public class CreateSheep : MonoBehaviour
    {

        public GameObject Sheep;


        public void SheepStart()
        {
            Instantiate(Sheep);
            Sheep.transform.position = new Vector3(34, 0, -33);
        }

    }
}