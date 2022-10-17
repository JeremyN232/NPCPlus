using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Beggar : INPC
    {
        //GameObject[] BeggarObj = GameObject.FindGameObjectsWithTag("Beggar");
        

        public void Speak()
        {
            Debug.Log("Beggar: Do you have some change to spare?");
        }

        public void spawn()
        {
            //BeggarObj.GetComponent<Renderer>().enabled = true;
            foreach (GameObject BeggarObj in GameObject.FindGameObjectsWithTag("Beggar"))
             {
                Renderer renderer = BeggarObj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = true;
                }
             }
        }
    }
}
