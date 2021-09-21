using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    float timer = 0.0f;
    int currentIntTimer = 0;

    public RuntimeAnimatorController virusUp;
    public RuntimeAnimatorController virusDown;
    public RuntimeAnimatorController virusLeft;
    public RuntimeAnimatorController virusRight;
    public RuntimeAnimatorController virusBlue;
    public RuntimeAnimatorController virusWhite;

    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        currentIntTimer = (int)timer;

        if (currentIntTimer > 0 && currentIntTimer < 3)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusUp;
        }
        if (currentIntTimer == 3)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusDown;
        }
        if (currentIntTimer == 6)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusLeft;
        }
        if (currentIntTimer == 9)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusRight;
        }
        if (currentIntTimer == 12)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusBlue;
        }
        if (currentIntTimer == 15)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusWhite;
        }
        if (currentIntTimer == 16)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusBlue;
        }
        if (currentIntTimer == 17)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusWhite;
        }
        if (currentIntTimer == 18)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusBlue;
        }
        if (currentIntTimer == 19)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusWhite;
        }
        if (currentIntTimer == 20)
        {
            transform.GetComponent<Animator>().runtimeAnimatorController = virusBlue;
            timer = 0;
        }
    }
}
