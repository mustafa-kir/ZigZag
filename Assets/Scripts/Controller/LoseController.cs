using UnityEngine.SceneManagement;
using UnityEngine;

public class LoseController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] [Range(0, 3)] private float lerpValue;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetLoseAreaSmoothFollow();
    }

    private void SetLoseAreaSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            SceneManager.LoadScene(0); 
        }
        
    }
}
