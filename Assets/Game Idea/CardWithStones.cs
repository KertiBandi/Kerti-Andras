using System.Collections.Generic;
using UnityEngine;

public class CardWithStones : MonoBehaviour
{

    List<Stone> stone = new List<Stone>();

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       Stone s =  collision.gameObject.GetComponent<Stone>();
        if(s != null)
        {
            stone.Add(s);
            Debug.Log(stone.Count);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Stone s = collision.gameObject.GetComponent<Stone>();
        if (s != null)
        {
            stone.Remove(s);
            Debug.Log(stone.Count);
        }



    }
    // házit  git repositoriba kell csinálni, majd azt publicra tenni



}
