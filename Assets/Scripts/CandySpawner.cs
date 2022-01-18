using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject candyInstance;

    void Start()
    {
        StartCoroutine(SpawnCandy());
    }

    IEnumerator SpawnCandy()
    {
        Vector2 pos = new Vector2(Random.Range(-408, 408), 400f);
        GameObject instance = Instantiate(original: candyInstance, parent: transform, position: Vector3.zero, rotation: Quaternion.identity);
        float scaleF = Random.Range(3, 6);
        Vector2 scale = new Vector2(scaleF, scaleF);
        instance.GetComponent<RectTransform>().localScale = scale;
        instance.GetComponent<RectTransform>().localPosition = pos;
        bool isBad = Random.Range(0, 2) != 0;
        if (isBad)
            instance.GetComponent<SpriteRenderer>().color = Color.black;
        SpriteRenderer[] dots = instance.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer dot in dots)
        {
            if (dot.GetComponent<RectTransform>() != instance.GetComponent<RectTransform>())
                dot.GetComponent<RectTransform>().localPosition = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
        }
        Destroy(instance, 4);
        yield return new WaitForSeconds(Random.Range(0.2f, 1f));
        StartCoroutine(SpawnCandy());
    }

}
