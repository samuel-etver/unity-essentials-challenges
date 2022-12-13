using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLabel : MonoBehaviour
{
    private void Start()
    {
        GameDurationTimer.GameEnd += OnGameEnd;
    }


    private void OnGameEnd()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Animator>().enabled = true;
        GameDurationTimer.GameEnd -= OnGameEnd;
    }

    private void OnDestroy()
    {
        GameDurationTimer.GameEnd -= OnGameEnd;
    }
}
