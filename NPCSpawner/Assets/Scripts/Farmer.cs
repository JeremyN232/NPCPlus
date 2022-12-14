using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Farmer : INPC
    {

        //GameObject FarmerObj = GameObject.Find("Farmer");

        public void Speak()
        {
            Debug.Log("Farmer: You reap what you sow!");
        }

        public void spawn()
        {
            foreach (GameObject FarmerObj in GameObject.FindGameObjectsWithTag("Farmer"))
             {
                Renderer renderer = FarmerObj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = true;
                }
             }
        }
    }
}
