using UnityEngine;

public class Plank1Movement : MonoBehaviour
{
    public float SpeedFactor = 1f;


    void Start()
    {
        Debug.Log("Started Plank 1 Movement");
    }


    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * SpeedFactor);
    }
}
