using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ConaLuk
{


    public class CurrencyCounter : MonoBehaviour
    {

        [SerializeField] private int clickCounter;
        [SerializeField] private TMP_Text currencyText;

        public void currencyCount()
        {
            clickCounter++;
            currencyText.SetText(clickCounter.ToString());
        }

    }
}