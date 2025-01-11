using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSwitch : MonoBehaviour
{
    public GameObject dog;
    public GameObject guineaPig;

    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            dog.SetActive(true);
            guineaPig.SetActive(false);
        }
        else
        {
            dog.SetActive(false);
            guineaPig.SetActive(true);
        }
    }

}
