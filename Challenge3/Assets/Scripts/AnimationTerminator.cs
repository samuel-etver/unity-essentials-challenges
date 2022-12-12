using UnityEngine;

public class AnimationTerminator : MonoBehaviour
{
    private void Start()
    {
        GameDurationTimer.GameEnd += OnGameEnd;   
    }


    private void OnGameEnd()
    {
        GetComponent<Animator>().enabled = false;
    }
}
