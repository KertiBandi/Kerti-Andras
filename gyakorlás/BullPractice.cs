using UnityEngine;

public class BullPractice : MonoBehaviour
{
    void Start()
    {
        bool b;
        b = true;
        b = false;

        int i1 = 23;
        int i2 = 30;

        bool areTheInsEqual = i1 == i2; //az egyenl�, egyenl� megvizsg�lja, hogy igaz-e?
        Debug.Log(areTheInsEqual);

        string s1 = "AAA";
        string s2 = "AAA";

        bool areTheStringsEqual = s1 == s2;
        Debug.Log(areTheStringsEqual);

        int i3 = 4, i4 = 78;
        bool areTheInsNotEqual = i3 != i4;  // != nem egyenl�

        Debug.Log(areTheInsNotEqual);

        bool areTheFirstHigher = i3 > i4;
        bool areTheFirstSmaller = i3 < i4;
        bool areTheFirstHigherOrEqual = i3 >= i4;
        bool areTheFirstSmallerOrEqual = i3 <= i4;
        //------------------------------------------------------------------------

        bool isGrounded = true; //F�ld�n �llunk e?
        int airJump = 1; //H�nyat tudunk ugrani a leveg�ben?


        bool canJump = isGrounded || (airJump>0);  // || vagy parancs
        // vagy parancsn�l, valamelyik true eset�n true

        int ammo = 23;
        float timeLeftSinceLastShot = 3.4f;
        float cooldown = 1;

        bool canShoot = ammo > 0 && timeLeftSinceLastShot >= cooldown; // && �s parancs

        bool coolDownOver = timeLeftSinceLastShot >= cooldown;
        bool haveAmmo = ammo > 0;
        canShoot = haveAmmo && coolDownOver;

        bool canNotShot = !canShoot;  // ! logikai neg�l�s

        //XOR   kiz�r�vagy
        bool xor = true ^ true;

    }


}
