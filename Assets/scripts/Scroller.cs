using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    #region --- helper ---
    private struct Background
    {
        public GameObject sprite;
        public float percent;
    }
    #endregion

    public float Speed = -1.0f;
    public GameObject PrefabBackground = null;
    public int OrderInlayer = 0;
    public float Multipler = 1.0f;
    private Background firstBackground;
    private Background secondBackground;
    private float Width;
    private float xStart;
    private float xEnd;

    private void Start()
    {
        //make 1st background sprite
        firstBackground.sprite = Instantiate(PrefabBackground, this.transform);
        firstBackground.sprite.GetComponent<SpriteRenderer>().sortingOrder = OrderInlayer;
        firstBackground.percent = 0.5f;

        //make 2nd background sprite
        secondBackground.sprite = Instantiate(PrefabBackground, this.transform);
        secondBackground.sprite.GetComponent<SpriteRenderer>().sortingOrder = OrderInlayer;
        secondBackground.percent = 1.0f;

        //sprite size determines start and end scrolling positions
        Width = firstBackground.sprite.GetComponent<SpriteRenderer>().bounds.size.x;
        xStart = Width;
        xEnd = -Width;
    }

    private void Update()
    {
        //Notes: 
        //  Mathf.Repeat keeps percent between 0.0 .. 1.0 (0 - 100 percent)
        //  Mathf.Lerp gives me a position between start and end based on percent
        //  how fast or slow we change percent, is how fast we scroll

        firstBackground.percent = Mathf.Repeat(firstBackground.percent - (Speed * Multipler * Time.deltaTime), 1.0f);
        float xPos1 = Mathf.Lerp(xStart, xEnd, firstBackground.percent);
        firstBackground.sprite.transform.position = new Vector3(xPos1, 0, 0);
    }
}