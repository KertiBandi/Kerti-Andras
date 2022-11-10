using UnityEngine;

public class Vampire : MonoBehaviour
{
    [SerializeField] int gold = 0;
    [SerializeField] int hP = 0;
    [SerializeField] int priceBB  = 10;
    [SerializeField] int priceTT = 4;
    [SerializeField] int priceVF = 13;
    [SerializeField] int buyBB;
    [SerializeField] int buyTT;
    [SerializeField] int buyVF;
    [SerializeField] int totalPrice;
    [SerializeField] int totalBloodPrice;
    [SerializeField] string canWeBuyIt;
    [SerializeField] string canWeBuyItWithBlood;
    [SerializeField] string goldAndBlood;


    void OnValidate()
       
    {


        totalPrice = (priceBB*buyBB) + (priceTT*buyTT) + (priceVF*buyVF);
        totalBloodPrice = totalPrice * 5;
                
        if (gold >= totalPrice)
        {
            canWeBuyIt = "Yes";
        }
            else
        {
            canWeBuyIt = "No";
        }
        
        if (hP > totalBloodPrice)
        {
            canWeBuyItWithBlood = "Yes";
        }
        else
        {
            canWeBuyItWithBlood = "No";
        }
      


        if (hP > ((totalPrice-gold)*5))
        {
            goldAndBlood = "Yes";
        }
               else
        {
            goldAndBlood = "No";
        }


    }
















}
