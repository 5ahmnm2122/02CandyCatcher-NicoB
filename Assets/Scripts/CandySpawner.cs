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
        instance.GetComponent<RectTransform>().localPosition = pos;
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnCandy());
    }

}
