using UnityEngine;

public class Board : MonoBehaviour
{
    private const int Size = 8;
    [SerializeField] private Celll cellPrefab;
  
    [SerializeField] private Transform cellsTransform;

    private readonly Celll[,] cells = new Celll[Size, Size];

    private void Start()
    {
        CreateCells();
    }

    private void CreateCells()
    {
        for (int x = 0; x < Size; x++)
        {
            for (int y = 0; y < Size; y++)
            {
                Celll cell = Instantiate(cellPrefab, cellsTransform);
                cell.transform.localPosition = new Vector3(x, y, 0);
                cells[x, y] = cell;
            }
        }
    }
}