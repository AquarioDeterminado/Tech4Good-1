using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TitleScreenOpenBpx : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Sprite closedLid;
    [SerializeField] private Sprite halfOpen;
    private Image _image;

    // Start is called before the first frame update
    void Start()
    {
        _image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPon(PointerEventData eventData)
    {
       //TODO: Start Game; init player; move camera; move title
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("bonk");
        _image.sprite = halfOpen;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.sprite = closedLid;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
