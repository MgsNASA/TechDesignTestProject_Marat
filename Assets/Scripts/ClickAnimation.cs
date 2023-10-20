using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    private Animator animator;


    private void Start( )
    {
        animator = GetComponent<Animator> ();

    }

    private void Update( )
    {
        // Проверяем клик мышью (или прикосновение на мобильных устройствах)
        if ( Input.GetMouseButtonDown ( 0 ) )
        {
            // Создаем луч (ray) из точки клика
            Ray ray = Camera.main.ScreenPointToRay ( Input.mousePosition );
            RaycastHit2D hit = Physics2D.GetRayIntersection ( ray );

            // Проверяем, попали ли мы по объекту с коллайдером
            if ( hit.collider != null && hit.collider.gameObject == gameObject )
            {
             
                    animator.SetTrigger ( "PlayAnimation" ); // "PlayAnimation" - имя триггера анимации 
                
            }
        }
    }
}
