using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        print(gameObject.name + ":" + i);
        if (tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (tag == "Blue" && i >= 200 && i <= 250)
        {
            rend = GetComponent<Renderer>();
            rend.enabled = false;
        }
    }
}
