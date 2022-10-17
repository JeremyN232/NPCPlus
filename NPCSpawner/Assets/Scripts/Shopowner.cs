using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Shopowner : INPC
    {
        //GameObject ShopObj = GameObject.Find("Shopowner");

        public void Speak()
        {
            Debug.Log("Shopowner: Do you wish to purchase something?");
        }

        public void spawn()
        {
            foreach (GameObject ShopObj in GameObject.FindGameObjectsWithTag("ShopOwner"))
             {
                Renderer renderer = ShopObj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = true;
                }
             }
        }
    }
}