using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int row;
    public int col;
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnManager()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Vector3 Position = new Vector3(transform.position.x + row, transform.position.y,
                transform.position.z + col);
                Instantiate(cubePrefab, Position, cubePrefab.transform.rotation);
            }
        }
    }
}
