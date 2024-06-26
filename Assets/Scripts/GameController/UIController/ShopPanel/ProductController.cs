﻿using UnityEngine;
using System.Collections;

public class ProductController : MonoBehaviour
{

    // Use this for initialization
    public ProductDataController.ProductData productData;

    private UITexture iconTypeTexture;
    private UITexture iconTexture;
    private UILabel valueLabel;
    private UILabel priceLabel;



    void Awake()
    {
        iconTypeTexture = Master.GetChildByName(gameObject, "IconType").GetComponent<UITexture>();
        iconTexture = Master.GetChildByName(gameObject, "Icon").GetComponent<UITexture>();
        valueLabel = Master.GetChildByName(gameObject, "ValueLabel").GetComponent<UILabel>();
        priceLabel = Master.GetChildByName(gameObject, "PriceLabel").GetComponent<UILabel>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetInfo(ProductDataController.ProductData productData)
    {
        this.productData = productData;

        if (productData.Type == "Gem")
        {
            iconTypeTexture.mainTexture = Resources.Load<Texture2D>("Textures/UI/gem_icon_new");
        }
        else if (productData.Type == "Star")
        {
            iconTypeTexture.mainTexture = Resources.Load<Texture2D>("Textures/UI/star_icon_new");
        }

        iconTexture.mainTexture = Resources.Load<Texture2D>("Textures/UI/Menu/ProductsIcon/" + productData.ProductIcon);
        valueLabel.text = productData.Value.ToString();
        priceLabel.text = "$" + productData.Price.ToString();
    }

    public void OnTouchIn()
    {
        //todo iap in here
        /*Master.IAP.PurchaseProduct(productData.ProductID, () =>
        {
            if (productData.Type == "Gem")
            {
                Master.Stats.Gem += productData.Value;
            }
            if (productData.Type == "Star")
            {
                Master.Stats.Star += productData.Value;
            }
        });*/
        IAPManager.OnPurchaseSuccess = Buy;
        IAPManager.Instance.BuyProductID(productData.ProductID);
    }

    private void Buy()
    {
        if (productData.Type == "Gem")
        {
            Master.Stats.Gem += productData.Value;
        }
        if (productData.Type == "Star")
        {
            Master.Stats.Star += productData.Value;
        }
    }

}
