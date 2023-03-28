using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

namespace ConaLuk
{

    public class DestroySheep : MonoBehaviour
    {

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.activeSelf)
            {
                GameManager.Money();
                Destroy(other.gameObject);
            }

        }


    }
}
