using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace ConaLuk
{
    public class GameManager : MonoBehaviour
    {
        private static int money;
        [SerializeField] private TMP_Text currencyText;
        [SerializeField] private GameObject moneyTrigger;
        [SerializeField] private Canvas shopcanvas;
        [SerializeField] private Button upgradeOne;
        [SerializeField] private Button upgradeTwo;
        [SerializeField] private Button upgradeThree;
        [SerializeField] private Button upgradeFour;


        public void Start()

        { 
            money = 0;
            shopcanvas.enabled = false;
            upgradeOne.enabled = false;
            upgradeTwo.enabled = false;
            upgradeThree.enabled = false;
            upgradeFour.enabled = false;

        }

        public void ShopOn()
        {
            shopcanvas.enabled = true;
        }

        public void ShopOff()
        {
            shopcanvas.enabled = false;
        }

        public static void Money()
        {
            money++;
        }

        public void Update()
        {
            currencyText.SetText(money.ToString());

            if (money >= 10)
            {
                upgradeOne.enabled = true;
            }

            if(money >= 20)
            {
                upgradeTwo.enabled = true;
            }

            if(money >= 100)
            {
                upgradeThree.enabled = true;
            }

            if(money >= 9999)
            {
                upgradeFour.enabled = true;
            }
        }
    


    }
}