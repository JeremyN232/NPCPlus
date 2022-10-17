using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Shopowner : INPC
    {
        GameObject ShopObj = GameObject.Find("Shopowner");

        public void Speak()
        {
            Debug.Log("Shopowner: Do you wish to purchase something?");
        }

        public void spawn()
        {
            ShopObj.GetComponent<Renderer>().enabled = true;
        }
    }
}