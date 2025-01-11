using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameSubMenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 9;
    public GameObject menu;

    // Update is called once per frame
    void Update()
    {
        menu.transform.position = head.position + new Vector3(head.forward.x, 0.1f, head.forward.z).normalized * spawnDistance;
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }
}
