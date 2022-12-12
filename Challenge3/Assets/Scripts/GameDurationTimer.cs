using System.Collections;
using UnityEngine;

public class GameDurationTimer : MonoBehaviour
{
    public int Duration = 60; // secs

    public delegate void OnGameEnd();
    public static OnGameEnd GameEnd;


    private void Start()
    {
        StartCoroutine(Wait());
    }


    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(Duration);
        Debug.Log("Duration expired");
        GameEnd();
    }
}
