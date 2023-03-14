using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ConaLuk
{


    public class GameManager : MonoBehaviour
    {

        [SerializeField] private Canvas shopcanvas;
        [SerializeField] private int money;
        [SerializeField] private Button upgradeOne;
        [SerializeField] private Button upgradeTwo;
        [SerializeField] private Button upgradeThree;
        [SerializeField] private Button upgradeFour;

        public static int clickCounter;
        [SerializeField] private TMP_Text currencyText;


        private void Start()

        {
            clickCounter = 0;
            shopcanvas.enabled = false;
            upgradeOne.enabled = false;
            upgradeTwo.enabled = false;
            upgradeThree.enabled = false;
            upgradeFour.enabled = false;

        }

        public void currencyCount()
        {
            clickCounter++;
            currencyText.SetText(clickCounter.ToString());
        }

        public void ShopOn()
        {
            shopcanvas.enabled = true;
        }

        public void ShopOff()
        {
            shopcanvas.enabled = false;
        }

        public void Update()
        {

            if (clickCounter >= 10)
            {
                upgradeOne.enabled = true;
            }

            if(clickCounter >= 20)
            {
                upgradeTwo.enabled = true;
            }

            if(clickCounter >= 100)
            {
                upgradeThree.enabled = true;
            }

            if(clickCounter <= 1000)
            {
                upgradeFour.enabled = true;
            }
        }
    }
}