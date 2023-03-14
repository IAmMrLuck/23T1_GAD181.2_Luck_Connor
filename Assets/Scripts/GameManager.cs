using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace ConaLuk
{
    public class GameManager : MonoBehaviour
    {

        public static int money = 0;
        [SerializeField] private Canvas shopcanvas;
        [SerializeField] private int i;
        [SerializeField] private Button upgradeOne;
        [SerializeField] private Button upgradeTwo;
        [SerializeField] private Button upgradeThree;
        [SerializeField] private Button upgradeFour;


        public void Start()

        { 

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

        public void Update()
        {

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

            if(money >= 1000)
            {
                upgradeFour.enabled = true;
            }
        }



    }
}