using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBottonManager : MonoBehaviour
{

    private Sprite itemImage;
    private GameObject item3DModel;
    private string itemName;
    public string ItemName{ 
        set{
            itemName = value;
        } 
    }

    private string itemDescription;
    public string ItemDescription {set => itemDescription = value;}
    public Sprite ItemImage {set=> itemImage = value;}
    public GameObject Item3DModel {set => item3DModel = value;}

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<Text>().text = itemName;
        transform.GetChild(1).GetComponent<RawImage>().texture = itemImage.texture;
        transform.GetChild(2).GetComponent<Text>().text = itemDescription;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.instance.ARPosition);
        button.onClick.AddListener(Create3Dmodel);
    }

    private void Create3Dmodel()
    {
        Instantiate(item3DModel);
    }

}
