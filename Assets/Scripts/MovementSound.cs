using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSound : MonoBehaviour
{
    public AudioSource footSteps;
    public AudioSource attack;

    private void FootStep()
    {
        footSteps.Play();
    }
    private void AttackSound()
    {
        attack.Play();
    }
}
