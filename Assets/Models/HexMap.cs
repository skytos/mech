using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    public GameObject HexPrefab;

    // Update is called once per frame
    public void GenerateMap()
    {
        for (int column = 0; column < 10; column++) {
            for (int row = 0; row < 10; row++) {
                Instantiate(
                    HexPrefab,
                    new Vector3(column, 0, row),
                    Quaternion.identity,
                    this.transform
                );
            }
        }
    }
}
