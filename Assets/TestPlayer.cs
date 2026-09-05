using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Configuracion")]
    public float speed = 10.0f;
    public string playerName = "Darebu";

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        
    }
}
