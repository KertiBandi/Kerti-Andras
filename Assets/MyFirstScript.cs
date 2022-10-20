using UnityEngine;

class MyFirstScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello world!");
        Debug.Log("Hello " + name);

        //komment
        /*ez is komment*/
        int myFirstVar;
        myFirstVar = 9;


        Debug.Log(myFirstVar);
        int aaa = 456;
        int a = 3, b = 4, c = 8;
        int x, y, z;

        int integerNumber = 231;
        float myFloatingPointNumber = 123.54f;
        string myFirstString = "sdgfsdtg";
        bool myFirstBool = true;
        myFirstBool = false;

        int summa = a + b;
        Debug.Log(summa);  //7
        int dif = a - 44;  //-41
        dif = dif - 5; // 46
        dif -= 5; //51

        int num = 6;
        num = num + 1;
        num += 1;
        num++;


        int product = a * 5; //15
        int ratio = a / 5; //0

        int modulo = 34 % a;  //osztás esetén a maradék = 1

        var iii = 23;
        var rtg = "dfgdg";

        int xxx = 3 + 2 * 4;  //11 mûveleti sorrend miatt
        xxx = (3 + 2) * 4; // 20 zárojelezés mûködik

        string s1 = "Hello";
        string s2 = "World";
        string s3 = s1 + s2; //HelloWorld

        int i1 = 3, i2 = 7;

        string s4 = s1 + i1; //Hello3

        string s5 = s1 + i1 + i2; //Hello37
        string s6 = i2.ToString();

        string s7 = i1 + i2 + s1; //10Hello

        float ff1 = 3.5f;
        int ii1 = 4;

        int ii2 = (int)ff1;
        float ff2 = ii1;

        string numberText = "234";

        int ii3 = int.Parse(numberText);



    }



}
