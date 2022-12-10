using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
        var n = FruitsList.Count;

        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            var index = Random.Range(0, n);
            var fruitPrefab = FruitsList[index];
            Vector3 fruitPosition = transform.TransformPoint(Vector3.zero);
            var fruit = Instantiate(fruitPrefab, fruitPosition, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
            var fruitScale = 0.08f;
            fruit.transform.localScale -= new Vector3(fruitScale, fruitScale, fruitScale);
        }
    }
}
