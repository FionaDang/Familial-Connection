using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public GameObject startobj;
    public LevelTracking myObject;
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Bowl"))
        {
            myObject.dogTask2Complete();
            myObject.checkAnimal(0);
            startobj.SetActive(true);
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Bone"))
        {
            myObject.dogTask3Complete();
            myObject.checkAnimal(0);
            startobj.SetActive(true);
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Carrot"))
        {
            myObject.guineaTask2Complete();
            myObject.checkAnimal(1);
            startobj.SetActive(true);
            other.gameObject.SetActive(false);
        }
        else if(other.gameObject.CompareTag("Brush"))
        {
            myObject.guineaTask3Complete();
            myObject.checkAnimal(1);
            startobj.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
