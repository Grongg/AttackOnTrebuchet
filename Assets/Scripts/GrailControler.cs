using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrailControler : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    private int currentHearts;
    void Start()
    {
        currentHearts = 3;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (currentHearts - 1 > 0)
            {
                Destroy(hearts[currentHearts - 1]);
                currentHearts--;
            }
            else
            {
                Destroy(hearts[currentHearts - 1]);
                //insert death scene loader 
            }
        }
    }

    void Update()
    {
        
    }
}
