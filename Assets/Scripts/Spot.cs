using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour
{
    [SerializeField] private float time = 2f;//частота стрельбы
    private float refresh = 0f;
    Light lightSpot;
    private void Awake()
    {
        lightSpot = GetComponent<Light>();
    }
    void Update()
    {
        if (refresh <= 0)
        {
            refresh = time;
            lightSpot.enabled= true;
        }
        if(refresh <= 1.0f)
        {
            lightSpot.enabled = false;
        }
        if (refresh > 0)
        {
            refresh -= Time.deltaTime;
        }
    }
}
