using UnityEngine;

public class Plank2Rotation : MonoBehaviour
{
    public float SpeedFactor = 50.0f;


    private void Start()
    {
        Debug.Log("Started Plank 2 Rotation");
    }


    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * SpeedFactor);
    }
}
