using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTracking : MonoBehaviour
{
    public int dLevel;
    public int gLevel;
    public TMP_Text title;
    public TMP_Text description;

    void Start()
    {
        dLevel = 1;
        gLevel = 1;
    }

    public void dogTask1Complete()
    {
        if(dLevel == 1) dLevel++;
    }
    public void dogTask2Complete()
    {
        if (dLevel == 2) dLevel++;
    }
    public void dogTask3Complete()
    {
        if (dLevel == 3) dLevel++;
    }
    public void guineaTask1Complete()
    {
        if (gLevel == 1) gLevel++;
    }
    public void guineaTask2Complete()
    {
        if (gLevel == 2) gLevel++;
    }
    public void guineaTask3Complete()
    {
        if (gLevel == 3) gLevel++;
    }
    public void checkAnimal(int index)
    {
        if(index == 0)
        {
            setDogMessage();
        }
        else
        {
            setGuineaMessage();
        }
    }

    void setDogMessage()
    {
        title.SetText("Level " + dLevel);
        if (dLevel == 1)
        {
            description.SetText("Task: Find the dog");
        }
        else if (dLevel == 2)
        {
            description.SetText("Task: Feed the dog");
        }
        else if (dLevel == 3)
        {
            description.SetText("Task: Play with the dog");
        }
        else
        {
            title.SetText("Max Level");
            description.SetText("You have reached max bonding with your dog. Make sure to occasionally take care of it!");
        }
    }
    void setGuineaMessage()
    {
        title.SetText("Level " + gLevel);
        if (gLevel == 1)
        {
            description.SetText("Task: Find the guinea pig");
        }
        else if (gLevel == 2)
        {
            description.SetText("Task: Feed the guinea pig");
        }
        else if (gLevel == 3)
        {
            description.SetText("Task: Groom the guinea pig");
        }
        else
        {
            title.SetText("Max Level");
            description.SetText("You have reached max bonding with your guinea pig. Make sure to occasionally take care of it!");
        }
    }
}
