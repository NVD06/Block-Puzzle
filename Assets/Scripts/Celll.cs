using UnityEngine;

public class Celll : MonoBehaviour
{
    [SerializeField] private Sprite NormalSprite;
    [SerializeField] private Sprite HighLightedSprite;

    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Highlight()
    {
        gameObject.SetActive(true);
        spriteRenderer.color = Color.white;
        spriteRenderer.sprite = HighLightedSprite;
    }

    public void Normal()
    {
        gameObject.SetActive(true);
        spriteRenderer.color = Color.white;
        spriteRenderer.sprite = NormalSprite;
    }

    public void Hover()
    {
        gameObject.SetActive(true);
        spriteRenderer.color = new Color(1f, 1f, 1f, 0.5f); // Set semi-transparent color
        spriteRenderer.sprite = NormalSprite;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
