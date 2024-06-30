using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager instance;

    [SerializeField] int gridSize;
    [SerializeField] float cellSize;

    [SerializeField] GameObject cellPrefab;
    [SerializeField] Transform gridParent;

    private void Awake()
    {
        instance = this;
    }

    public void Init()
    {
        float totalLength = (gridSize - 1) * cellSize;
        Vector2 startPos = -Vector2.one * (totalLength / 2f);

        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Vector2 newPos = startPos + new Vector2(j * cellSize, i * cellSize);
                GameObject newCell = Instantiate(cellPrefab, newPos, Quaternion.identity, gridParent);
                
            }
        }
    }
}
