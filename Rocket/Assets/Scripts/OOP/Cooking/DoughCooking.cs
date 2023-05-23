using System;
using System.Collections.Generic;
using UnityEngine;

namespace OOP.Cooking
{
    public class DoughCooking : MonoBehaviour
    {
        [SerializeField] private List<Transform> positionsForIngredients;

        private int _counter;

        private void Update()
        {
            if (Input.touchCount > 0)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint
                    (Input.GetTouch(0).position), Vector3.forward);
                if (hit.collider)
                {
                    if (hit.collider.TryGetComponent(out Ingredient ingredient))
                    {
                        if (_counter < positionsForIngredients.Count)
                            ingredient.transform.position = positionsForIngredients[_counter++].position;
                    }
                }
            }
        }
    }
}