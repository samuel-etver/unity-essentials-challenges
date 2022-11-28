using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeder : MonoBehaviour
{
    public List<GameObject> FruitsList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Feed());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Feed()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("feed");
        }
    }
}
