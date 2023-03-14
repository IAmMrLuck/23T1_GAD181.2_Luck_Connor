using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ConaLuk
{

    public class DestroySheep : MonoBehaviour
    {
        [SerializeField] private TMP_Text currencyText;
        private GameManager gameManager;
        int money;

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.activeSelf)
            {
                money++;
                currencyText.SetText(money.ToString());
                Destroy(other.gameObject);
            }

        }

    }
}
