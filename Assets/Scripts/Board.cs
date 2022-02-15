using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject board;
    // Start is called before the first frame update
    void Start()
    {
        this.board = GameObject.Find("Board");
        CreateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateBoard()
    {
        const int size = 7;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                var tile = new GameObject($"Tile {size * i + j}");
                tile.transform.SetParent(board.transform);

                var spriteRenderer = tile.AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/Corner");
                tile.transform.Rotate(Vector3.forward * -90 * i);
                tile.transform.position = new Vector2(-3.0f + 1f * j , 3.0f - 1f * i);
            }
        }
    }
}
