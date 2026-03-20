using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField] private Block[] blocks;

    private void Start()
    {
        var blockWidth = (float)Board.Size/blocks.Length;
        var cellSize = (float)Board.Size/(Board.Size*blocks.Length+ blocks.Length+1);
        for (int i = 0; i < blocks.Length; i++)
        {
            var block = blocks[i];
            block.transform.localScale = new Vector3(blockWidth, cellSize, 1);
            block.transform.localPosition = new Vector3(i * (blockWidth + cellSize) + cellSize, Board.Size + cellSize, 0);
        }
        
    }

}
