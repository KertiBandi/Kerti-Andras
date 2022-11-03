using UnityEngine;

class MeanPractice: MonoBehaviour
{

    [SerializeField] int number1, number2;
    [SerializeField] string text;

    private void OnValidate()
    {

        if (number2 == 0)
        {
            text = "Nullával nem tudunk osztani.";

        }
        else
        {

            int wholes = number1 / number2;
            int remainder = number1 % number2;

            text = $"{number1}-ben a {number2} megvan {wholes}-szor. Maradék a {remainder}.";
        }

       


    }

}
