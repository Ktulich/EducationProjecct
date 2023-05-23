using UnityEngine;
using UnityEngine.UI;

namespace OOP.StoveScene
{
    public class Stove : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer mask;

        public void AddLightningToStove(float alpha)
        {
            mask.color = new Color(mask.color.r, mask.color.g, mask.color.b, mask.color.a - alpha);
        }

        public void RemoveLightningFromStove()
        {
            mask.color = new Color(mask.color.r, mask.color.g, mask.color.b, mask.color.a + 100);
        }
    }
}