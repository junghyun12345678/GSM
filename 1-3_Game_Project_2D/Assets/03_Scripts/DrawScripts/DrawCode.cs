using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class DrawCode : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {

    }

    public void randomButton()
    {
        int random = Random.Range(1, 4);
 
        UIManager.Instance.Number = random;
    }
}
