using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class HealthManager : MonoBehaviour
{

    public ThirdPersonController thirdPersonController;

    public float speedCutoff = .1f;

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = thirdPersonController.GetSpeed();
        if (currentSpeed < speedCutoff)
        {
            //LOSE HEALTH
        }
    }
}
