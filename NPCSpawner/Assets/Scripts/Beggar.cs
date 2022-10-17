using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Beggar : INPC
    {
        GameObject BeggarObj = GameObject.FindGameObjectWithTag("Beggar");

        public void Speak()
        {
            Debug.Log("Beggar: Do you have some change to spare?");
        }

        public void spawn()
        {
            BeggarObj.SetActive(true);
        }
    }
}
